using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace WcfExtension.ConfigCenter
{
    using System.Configuration;
    using ServiceStack.Redis;
    using System.Xml.Linq;

    public partial class WFWcfConfig : System.Web.UI.Page
    {
        /// <summary>
        /// default address is 192.168.129.175
        /// </summary>
        private static readonly string REDISHOST = ConfigurationManager.AppSettings["redis_address"];

        /// <summary>
        ///  default channel is WcfConfigClientChange
        /// </summary>
        private static readonly string REDISMESSAGECLIENTCHANNEL = ConfigurationManager.AppSettings["redis_message_client_channel"];

        private static readonly string REDISMESSAGESERVERCHANNEL = ConfigurationManager.AppSettings["redis_message_service_channel"];

        private static PooledRedisClientManager cm = new PooledRedisClientManager(REDISHOST);

        /// <summary>
        /// 消息发到Redis，其他客户端（ServiceServer|ClientServer）会自动订阅并更新
        /// </summary>
        protected void PublisherToRedisMessageChannel(string messagechannelname, string message)
        {
            using (var client = cm.GetClient())
            {
                client.PublishMessage(messagechannelname, message);

                Response.Write("发布Message成功");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.InitServerFarms();
                this.InitService();
                this.InitBinding();
                this.InitClientEndPoint();
                this.InitServiceEndPoint();
            }
        }

        private void InitServiceEndPoint()
        {
            var wcfconfigdatacontext = new WcfConfigDataContext();

            var query =
                (from serviceendpoint in wcfconfigdatacontext.ServiceEndpoints
                 select serviceendpoint);

            this.InitGV(this.GVSEPServiceEndPoint, query);

            var query2 =
                (from binding in wcfconfigdatacontext.Bindings
                 select binding);

            this.DDLSEPServiceEndPointBindingName.DataSource = query2;
            this.DDLSEPServiceEndPointBindingName.DataTextField = "BindingName"; /// Binding表里的BindingName
            this.DDLSEPServiceEndPointBindingName.DataValueField = "BindingName";
            this.DDLSEPServiceEndPointBindingName.DataBind();
        }

        protected void InitServerFarms()
        {
            var wcfconfigdatacontext = new WcfConfigDataContext();

            var query =
                (from serverfarm in wcfconfigdatacontext.ServerFarms
                 select serverfarm);

            this.InitGV(this.GVServerFarm, query);

            this.DDLServerFarm.DataSource = query;
            this.DDLServerFarm.DataTextField = "ServerFarmName";
            this.DDLServerFarm.DataValueField = "ServerFarmName";
            this.DDLServerFarm.DataBind();
        }

        protected void InitService()
        {
            var wcfconfigdatacontext = new WcfConfigDataContext();

            var query =
                (from service in wcfconfigdatacontext.Services
                 select service);

            this.InitGV(this.GVService, query);
        }

        protected void InitBinding()
        {
            var wcfconfigdatacontext = new WcfConfigDataContext();

            var query =
                (from binding in wcfconfigdatacontext.Bindings
                 select binding);

            this.InitGV(this.GVBinding, query);
        }

        protected void InitClientEndPoint()
        {
            var wcfconfigdatacontext = new WcfConfigDataContext();

            var query =
                (from clientendpoint in wcfconfigdatacontext.ClientEndpoints
                 select clientendpoint);

            this.InitGV(this.GVClientEndPoint, query);
        }

        private void InitGV(GridView gv, IQueryable query)
        {
            gv.DataSource = query;
            gv.DataBind();
        }

        private void OnDeleteSubmit<T>(WcfConfigDataContext wcfconfigdatacontext, T entity, Label errorlabel, Action[] callback)
            where T : class
        {
            try
            {
                var query =
                    (from e in wcfconfigdatacontext.GetTable<T>()
                     where e == entity
                     select e);

                wcfconfigdatacontext.GetTable<T>().DeleteOnSubmit(entity);

                wcfconfigdatacontext.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);

                wcfconfigdatacontext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
            }
            catch (Exception ex)
            {
                errorlabel.Text = ex.Message;
            }
            finally
            {
                foreach (Action act in callback)
                {
                    act();
                }
            }
        }

        private void OnAddSubmit<T>(T newobj, Label errorlabel, Action[] callback)
            where T : class
        {
            try
            {
                var wcfconfigdatacontext = new WcfConfigDataContext();

                wcfconfigdatacontext.GetTable<T>().InsertOnSubmit(newobj);

                wcfconfigdatacontext.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                wcfconfigdatacontext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                errorlabel.Text = "添加成功";
            }
            catch (Exception ex)
            {
                errorlabel.Text = ex.Message;
            }
            finally
            {
                foreach (Action act in callback)
                {
                    act();
                }
            }
        }

        protected void BtnAddServerFarm_Click(object sender, EventArgs e)
        {
            var name = TBServerFarmName.Text.Trim();
            var address = TBServerFarmAddress.Text.Trim();

            var context = new WcfConfigDataContext();
            var query =
                (from serverfarm in context.ServerFarms
                 where serverfarm.ServerFarmName == name
                 select serverfarm);

            if (query.Count() < 1) // create
            {
                this.OnAddSubmit<ServerFarm>(
                   new ServerFarm()
                   {
                       ServerFarmName = name,
                       ServerFarmAddress = address
                   },
                   this.LabelServerFarmErrorMessage,
                   new Action[] { 
                    this.InitServerFarms, 
                    this.InitService }
                       );
            }
            else
            {
                var obj = query.First<ServerFarm>();
                obj.ServerFarmName = name;
                obj.ServerFarmAddress = address;
                context.SubmitChanges();
                this.LabelServerFarmErrorMessage.Text = "修改成功";
                this.InitServerFarms();
                this.InitService();
            }

            this.LabelServerFarmErrorMessage.Focus();
        }

        protected void BtnAddService_Click(object sender, EventArgs e)
        {
            var servicetype = this.TBServiceType.Text.Trim();
            var behaviorxml = this.TBServiceBehaviorXml.Text.Trim();
            var serviceconfig = this.TBServiceConfig.Text.Trim();
            var servermachineIP = this.TBServerMachineIP.Text.Trim();

            var context = new WcfConfigDataContext();

            var query =
                (from service in context.Services
                 where service.ServiceType == servicetype
                 select service);

            if (query.Count() < 1)
            {
                this.OnAddSubmit<Service>(
                    new Service()
                    {
                        ServerFarmName = this.DDLServerFarm.SelectedValue,
                        ServiceType = servicetype,
                        ServiceBehaviorXml = string.IsNullOrEmpty(behaviorxml) ? null : XElement.Parse(behaviorxml),
                        ServiceConfig = string.IsNullOrEmpty(serviceconfig) ? null : XElement.Parse(serviceconfig),
                        ServerMachineIP = servermachineIP
                    },
                    this.LabelServiceErrorMessage,
                    new Action[] { 
                    this.InitService }
                    );
            }
            else
            {
                var obj = query.First<Service>();
                obj.ServerFarmName = this.DDLServerFarm.SelectedValue;
                obj.ServiceType = servicetype;
                obj.ServiceBehaviorXml =
                    string.IsNullOrEmpty(behaviorxml) ?
                        null : XElement.Parse(behaviorxml);
                obj.ServiceConfig =
                    string.IsNullOrEmpty(serviceconfig) ?
                        null : XElement.Parse(serviceconfig);
                obj.ServerMachineIP = servermachineIP;
                context.SubmitChanges();
                this.LabelServiceErrorMessage.Text = "修改成功";
                this.InitService();
            }
            this.LabelServiceErrorMessage.Focus();

        }

        protected void BtnAddClientEndPoint_Click(object sender, EventArgs e)
        {
            var servicecontracttype = this.TBServiceContractType.Text.Trim();
            var clientendpointbehaviorxml = this.TBClientEndpointBehaviorXml.Text.Trim();

            var context = new WcfConfigDataContext();

            var query =
                (from clientendpoint in context.ClientEndpoints
                 where clientendpoint.ServiceContractType == servicecontracttype
                 select clientendpoint);

            if (query.Count() < 1)
            {
                this.OnAddSubmit<ClientEndpoint>(
                    new ClientEndpoint()
                    {
                        ServiceContractType = servicecontracttype,
                        ClientMachineIP = "*",
                        ClientEndpointBehaviorXml =
                            string.IsNullOrEmpty(clientendpointbehaviorxml) ?
                                null : XElement.Parse(clientendpointbehaviorxml)
                    },
                    this.LabelClientEndPointErrorMessage,
                    new Action[] {
                    this.InitClientEndPoint }
                    );
            }
            else
            {
                var obj = query.First<ClientEndpoint>();
                obj.ServiceContractType = servicecontracttype;
                obj.ClientMachineIP = "*";
                obj.ClientEndpointBehaviorXml =
                    string.IsNullOrEmpty(clientendpointbehaviorxml) ?
                        null : XElement.Parse(clientendpointbehaviorxml);
                context.SubmitChanges();
                this.LabelClientEndPointErrorMessage.Text = "修改成功";
                this.InitClientEndPoint();
            }

            this.LabelClientEndPointErrorMessage.Focus();
            //this.PublisherToRedisMessageChannel(REDISMESSAGECLIENTCHANNEL, servicecontracttype);
        }

        protected void BtnAddBinding_Click(object sender, EventArgs e)
        {
            var bindingname = this.TBBindingName.Text.Trim();
            var bindingtype = this.DDLBindingType.SelectedValue;
            var bindingpriority = int.Parse(this.DDLBindingPriority.SelectedValue);
            var bindingxml = this.TBBindingXml.Text.Trim();
            var bindingprotocol = this.DDLBindingProtocol.SelectedValue;

            var context = new WcfConfigDataContext();

            var query =
                (from binding in context.Bindings
                 where binding.BindingName == bindingname
                 select binding);

            if (query.Count() < 1)
            {
                this.OnAddSubmit<Binding>(
                    new Binding()
                    {
                        BindingName = bindingname,
                        BindingType = bindingtype,
                        BindingPriority = bindingpriority,
                        BindingXml = string.IsNullOrEmpty(bindingxml) ? null : XElement.Parse(bindingxml),
                        BindingProtocol = bindingprotocol
                    },
                    this.LabelBindingErrorMessage,
                    new Action[] { 
                    this.InitBinding }
                        );
            }
            else
            {
                var obj = query.First<Binding>();
                obj.BindingName = bindingname;
                obj.BindingType = bindingtype;
                obj.BindingPriority = bindingpriority;
                obj.BindingXml = string.IsNullOrEmpty(bindingxml) ? null : XElement.Parse(bindingxml);
                obj.BindingProtocol = bindingprotocol;
                context.SubmitChanges();
                this.LabelBindingErrorMessage.Text = "修改成功";
                this.InitBinding();
            }

            this.LabelBindingErrorMessage.Focus();
            //this.PublisherToRedisMessageChannel(REDISMESSAGESERVERCHANNEL, bindingname);
        }

        protected void BtnAddServiceEndPoint_Click(object sender, EventArgs e)
        {
            var servicecontracttype = this.TBSEPServiceContractType.Text.Trim();
            var serviceContractversion = this.TBSEPServiceContractVersion.Text.Trim();
            var servicetype = this.TBSEPServiceType.Text.Trim();
            var serviceendpointbehaviorxml = this.TBSEPServiceEndPointBehaviorXml.Text.Trim();
            var serviceendpointbindingname = this.DDLSEPServiceEndPointBindingName.SelectedValue;
            var serviceendpointport = int.Parse(this.TBSEPServiceEndPointPort.Text.Trim());
            var serviceendpointname = this.TBSEPServiceEndPointName.Text.Trim();

            var context = new WcfConfigDataContext();

            var query =
                (from serviceendpoint in context.ServiceEndpoints
                 where serviceendpoint.ServiceContractType == servicecontracttype &&
                       serviceendpoint.ServiceContractVersion == serviceContractversion
                 select serviceendpoint);

            if (query.Count() < 1)
            {
                this.OnAddSubmit<ServiceEndpoint>(
                    new ServiceEndpoint()
                    {
                        ServiceContractType = servicecontracttype,
                        ServiceContractVersion = serviceContractversion,
                        ServiceType = servicetype,
                        ServiceEndpointBehaviorXml =
                            string.IsNullOrEmpty(serviceendpointbehaviorxml) ?
                                null : XElement.Parse(serviceendpointbehaviorxml),
                        ServiceEndpointBindingName = serviceendpointbindingname,
                        ServiceEndpointName = serviceendpointname,
                        ServerMachineIP = "*",
                        ServiceEndpointPort = serviceendpointport
                    },
                    this.LabelSEPServiceEndPointErrorMessage,
                    new Action[] { 
                    this.InitServiceEndPoint }
                    );
            }
            else
            {
                var obj = query.First<ServiceEndpoint>();
                obj.ServiceContractType = servicecontracttype;
                obj.ServiceContractVersion = serviceContractversion;
                obj.ServiceType = servicetype;
                obj.ServiceEndpointBehaviorXml =
                            string.IsNullOrEmpty(serviceendpointbehaviorxml) ?
                                null : XElement.Parse(serviceendpointbehaviorxml);
                obj.ServiceEndpointBindingName = serviceendpointbindingname;
                obj.ServiceEndpointName = serviceendpointname;
                obj.ServiceEndpointPort = serviceendpointport;
                obj.ServerMachineIP = "*";

                context.SubmitChanges();
                this.LabelSEPServiceEndPointErrorMessage.Text = "修改成功";
                this.InitServiceEndPoint();
            }

            this.LabelSEPServiceEndPointErrorMessage.Focus();
        }

        protected void GVServerFarm_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var gv = sender as GridView;

            if (gv.Rows.Count < 1)
            {
                e.Cancel = true;
                this.LabelServerFarmErrorMessage.Text = "无记录";

                return;
            }
            var serverfarmname = gv.Rows[e.RowIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from serverfarm in context.ServerFarms
                 where serverfarm.ServerFarmName == serverfarmname
                 select serverfarm);

            this.OnDeleteSubmit<ServerFarm>(
                context,
                query.First<ServerFarm>(),
                this.LabelServerFarmErrorMessage,
                new Action[] { 
                    this.InitServerFarms }
                );

            this.LabelServerFarmErrorMessage.Focus();
        }

        protected void GVService_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var gv = sender as GridView;

            if (gv.Rows.Count < 1)
            {
                e.Cancel = true;
                this.LabelServiceErrorMessage.Text = "无记录";

                return;
            }

            var servicetype = gv.Rows[e.RowIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from serverfarm in context.Services
                 where serverfarm.ServiceType == servicetype
                 select serverfarm);

            this.OnDeleteSubmit<Service>(
                context,
                query.First<Service>(),
                this.LabelServiceErrorMessage,
                new Action[] { 
                    this.InitService }
                );

            this.LabelServiceErrorMessage.Focus();
        }

        protected void GVSEPServiceEndPoint_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var gv = sender as GridView;

            if (gv.Rows.Count < 1)
            {
                e.Cancel = true;
                this.LabelSEPServiceEndPointErrorMessage.Text = "无记录";

                return;
            }

            var servicetracttype = gv.Rows[e.RowIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from serverfarm in context.ServiceEndpoints
                 where serverfarm.ServiceContractType == servicetracttype
                 select serverfarm);

            this.OnDeleteSubmit<ServiceEndpoint>(
                context,
                query.First<ServiceEndpoint>(),
                this.LabelSEPServiceEndPointErrorMessage,
                new Action[] { 
                    this.InitServiceEndPoint }
                );

            this.LabelSEPServiceEndPointErrorMessage.Focus();
        }

        protected void GVBinding_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var gv = sender as GridView;

            if (gv.Rows.Count < 1)
            {
                e.Cancel = true;
                this.LabelSEPServiceEndPointErrorMessage.Text = "无记录";

                return;
            }

            var bindingname = gv.Rows[e.RowIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from serverfarm in context.Bindings
                 where serverfarm.BindingName == bindingname
                 select serverfarm);

            this.OnDeleteSubmit<Binding>(
                context,
                query.First<Binding>(),
                this.LabelBindingErrorMessage,
                new Action[] { 
                    this.InitBinding }
                );

            this.LabelBindingErrorMessage.Focus();
        }

        protected void GVClientEndPoint_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var gv = sender as GridView;

            if (gv.Rows.Count < 1)
            {
                e.Cancel = true;
                this.LabelClientEndPointErrorMessage.Text = "无记录";

                return;
            }

            var servicecontracttype = gv.Rows[e.RowIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from serverfarm in context.ClientEndpoints
                 where serverfarm.ServiceContractType == servicecontracttype
                 select serverfarm);

            this.OnDeleteSubmit<ClientEndpoint>(
                context,
                query.First<ClientEndpoint>(),
                this.LabelClientEndPointErrorMessage,
                new Action[] { 
                    this.InitClientEndPoint }
                );

            this.LabelClientEndPointErrorMessage.Focus();
        }

        protected void GVClientEndPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GVClientEndPoint.Rows.Count < 1)
            {
                return;
            }

            var servicetratctype = GVClientEndPoint.Rows[GVClientEndPoint.SelectedIndex].Cells[1].Text;

            this.PublisherToRedisMessageChannel(REDISMESSAGECLIENTCHANNEL, servicetratctype);
        }

        protected void GVService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GVService.Rows.Count < 1)
            {
                return;
            }

            var servicetype = GVService.Rows[GVService.SelectedIndex].Cells[1].Text;

            this.PublisherToRedisMessageChannel(REDISMESSAGESERVERCHANNEL, servicetype);
        }

        protected void GVServerFarm_RowEditing(object sender, GridViewEditEventArgs e)
        {
            if (GVServerFarm.Rows.Count < 1)
            {
                return;
            }

            var key = GVServerFarm.Rows[e.NewEditIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from serverfarm in context.ServerFarms
                 where serverfarm.ServerFarmName == key
                 select serverfarm).First<ServerFarm>();

            if (query == null)
            {
                return;
            }

            this.TBServerFarmName.Text = query.ServerFarmName;
            this.TBServerFarmName.Focus();
            this.TBServerFarmAddress.Text = query.ServerFarmAddress;
        }

        protected void GVService_RowEditing(object sender, GridViewEditEventArgs e)
        {
            if (GVService.Rows.Count < 1)
            {
                return;
            }

            var key = GVService.Rows[e.NewEditIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from service in context.Services
                 where service.ServiceType == key
                 select service).First<Service>();

            this.DDLServerFarm.SelectedValue = query.ServerFarmName;
            this.DDLServerFarm.Focus();
            this.TBServiceType.Text = query.ServiceType;
            this.TBServerMachineIP.Text = query.ServerMachineIP;
            this.TBServiceBehaviorXml.Text = query.ServiceBehaviorXml.ToString();
            this.TBServiceConfig.Text = query.ServiceConfig.ToString();
        }

        protected void GVSEPServiceEndPoint_RowEditing(object sender, GridViewEditEventArgs e)
        {
            if (GVSEPServiceEndPoint.Rows.Count < 1)
            {
                return;
            }

            var key = GVSEPServiceEndPoint.Rows[e.NewEditIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from serviceendpoint in context.ServiceEndpoints
                 where serviceendpoint.ServiceContractType == key
                 select serviceendpoint).First<ServiceEndpoint>();

            this.TBSEPServiceContractType.Text = query.ServiceContractType;
            this.TBSEPServiceContractType.Focus();
            this.TBSEPServiceContractVersion.Text = query.ServiceContractVersion;
            this.TBSEPServiceType.Text = query.ServiceType;
            this.DDLSEPServiceEndPointBindingName.SelectedValue = query.ServiceEndpointBindingName;
            this.TBSEPServiceEndPointPort.Text = query.ServiceEndpointPort.ToString();
            this.TBSEPServiceEndPointName.Text = query.ServiceEndpointName;
            this.TBSEPServiceEndPointBehaviorXml.Text = query.ServiceEndpointBehaviorXml.ToString();
        }

        protected void GVBinding_RowEditing(object sender, GridViewEditEventArgs e)
        {
            if (GVBinding.Rows.Count < 1)
            {
                return;
            }

            var key = GVBinding.Rows[e.NewEditIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from binding in context.Bindings
                 where binding.BindingName == key
                 select binding).First<Binding>();

            this.TBBindingName.Text = query.BindingName;
            this.TBBindingName.Focus();
            this.DDLBindingType.SelectedValue = query.BindingType;
            this.DDLBindingProtocol.SelectedValue = query.BindingProtocol;
            this.DDLBindingPriority.SelectedValue = query.BindingPriority.ToString();
            this.TBBindingXml.Text = query.BindingXml.ToString();
        }

        protected void GVClientEndPoint_RowEditing(object sender, GridViewEditEventArgs e)
        {
            if (GVClientEndPoint.Rows.Count < 1)
            {
                return;
            }

            var key = GVClientEndPoint.Rows[e.NewEditIndex].Cells[1].Text;

            var context = new WcfConfigDataContext();

            var query =
                (from clientendpoint in context.ClientEndpoints
                 where clientendpoint.ServiceContractType == key
                 select clientendpoint).First<ClientEndpoint>();

            this.TBServiceContractType.Text = query.ServiceContractType;
            this.TBServiceContractType.Focus();
            this.TBClientEndpointBehaviorXml.Text = query.ClientEndpointBehaviorXml.ToString();
        }
    }
}