using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfExtension.LogCenter.Core;
using MongoDB.Bson;

namespace WcfExtension.LogCenter.Info
{
    public partial class LogList : System.Web.UI.Page
    {

        /// <summary>
        /// 当前页数
        /// </summary>
        public int PageIndex
        {
            get
            {
                if (ViewState["mypageindex"] == null)
                {
                    ViewState["mypageindex"] = 1;
                }
                return (int)ViewState["mypageindex"];
            }
            set
            {
                if (value > 0)
                {
                    ViewState["mypageindex"] = value;
                }
                else
                {
                    ViewState["mypageindex"] = 1;
                }
            }
        }

        public string currentDate;//当前日期
        public string collectionName;//列表名称

        public int number = 1;
        public string databaseName = "";
        public string dbName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                info_class();

                tbBeginDate.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " 23:59:59";
                tbEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59";
            }

            if (!IsPostBack)
            {
                //不显示
                //info_show();
            }
        }

        protected void info_show()
        {
            #region conditions 废弃

            ////ip
            //string ip = "";
            //if (ddlMachineIP.Text != "0")
            //{
            //    ip = ddlMachineIP.Text;
            //}

            ////页面名称
            //string pagename = "";
            //if (ddlPageUrl.Text != "0")
            //{
            //    pagename = ddlPageUrl.Text;
            //}
            ////等级
            //string level = "";
            //if (ddlLogLevel.Text != "0")
            //{
            //    level = ddlLogLevel.Text;
            //}
            ////类别名称
            //string categoryName = "";
            //if (ddlCategoryName.Text != "0")
            //{
            //    categoryName = ddlCategoryName.Text;
            //}
            ////日志内容
            //string message = "";
            //if (tbMessage.Text.Trim() != "")
            //{
            //    message = tbMessage.Text.Trim();
            //}

            //Document docWhere = new Document();

            //if (!string.IsNullOrEmpty(ip))
            //{
            //    docWhere.Append("MachineIP", ip);
            //}
            //if (!string.IsNullOrEmpty(pagename))
            //{
            //    docWhere.Append("PageName", pagename);
            //}
            //if (beginDate.HasValue && endDate.HasValue)
            //{
            //    docWhere.Append("WebServerTime", new Document().Append("$gte", beginDate).Append("$lte", endDate));
            //}
            //if (!string.IsNullOrEmpty(categoryName))
            //{
            //    docWhere.Append("CategoryName", categoryName);
            //}
            //if (!string.IsNullOrEmpty(level))
            //{
            //    docWhere.Append("LogLevel", int.Parse(level));
            //}
            //if (!string.IsNullOrEmpty(message))
            //{
            //    docWhere.Append("Message", "/^.*" + message + ".*/");//模糊查询  /^.*aa.*/ 相当于 like '%aa%'
            //}
            #endregion


            //开始日期时间. 结束日期时间
            DateTime? beginDate = DateTime.Parse(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " 23:59:59");
            DateTime? endDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59");
            if (tbBeginDate.Text != "")
            {
                //有日期有时间
                try
                {
                    beginDate = DateTime.Parse(tbBeginDate.Text);
                }
                catch
                {
                    beginDate = DateTime.Parse(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " 23:59:59");
                }

            }

            if (tbEndDate.Text != "")
            {
                //有日期有时间
                try
                {
                    endDate = DateTime.Parse(tbEndDate.Text);
                }
                catch
                {
                    endDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59");
                }

            }

            //分页查询

            currentDate = ddlMonth.Text;
            collectionName = ddlDatabaseName.Text;
            if (currentDate != "-1")
            {
                dbName = "WcfLog" + currentDate;//数据库名字

                #region 条件
                BsonDocument where = new BsonDocument();
                if (beginDate.HasValue && endDate.HasValue)
                {
                    where.Add("Time", new BsonDocument().Add("$gte", beginDate).Add("$lte", endDate));
                }
                #endregion

                #region 排序
                string[] orderby = { "Time" };
                #endregion

                #region 字段
                BsonDocument fields = new BsonDocument();
                #endregion

                //查询数据库
                if (collectionName == "ClientExceptionInfo")
                {
                    List<ClientExceptionInfo> list = MongoDBUtil.GetPaged<ClientExceptionInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else if (collectionName == "ClientInvokeInfo")
                {
                    List<ClientInvokeInfo> list = MongoDBUtil.GetPaged<ClientInvokeInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else if (collectionName == "ClientMessageInfo")
                {
                    List<ClientMessageInfo> list = MongoDBUtil.GetPaged<ClientMessageInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else if (collectionName == "ServerExceptionInfo")
                {
                    List<ServerExceptionInfo> list = MongoDBUtil.GetPaged<ServerExceptionInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else if (collectionName == "ServerInvokeInfo")
                {
                    List<ServerInvokeInfo> list = MongoDBUtil.GetPaged<ServerInvokeInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else if (collectionName == "ServerMessageInfo")
                {
                    List<ServerMessageInfo> list = MongoDBUtil.GetPaged<ServerMessageInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else if (collectionName == "ClientStartInfo")
                {
                    List<ClientStartInfo> list = MongoDBUtil.GetPaged<ClientStartInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else if (collectionName == "ServerStartInfo")
                {
                    List<ServerStartInfo> list = MongoDBUtil.GetPaged<ServerStartInfo>(dbName, collectionName, where, orderby, fields, PageIndex, 20);
                    Repeater1.DataSource = list;
                    Repeater1.DataBind();
                }
                else
                {

                    Repeater1.DataSource = new List<ServerStartInfo> { };
                    Repeater1.DataBind();
                }
            }

        }




        /// <summary>
        /// 绑定类别
        /// </summary>
        protected void info_class()
        {
            //string userName = Session["User_Name"].ToString();
            //UsersService us = new UsersService();
            //List<string> listGroupId = us.GetGroupIdByName(userName);

            //List<string> listDatabaseName = PublicInfoService.GetAllDatabaseName(listGroupId);

            //List<string> listMonth = UsersService.GetDbMonth(listDatabaseName);
            //ddlMonth.Items.Add(new ListItem("请选择年月", "0"));
            //listMonth.ForEach(x => ddlMonth.Items.Add(new ListItem(x)));


            //ddlDatabaseName.Items.Add(new ListItem("请选择数据库", "0"));
            //listDatabaseName.ForEach(x => ddlDatabaseName.Items.Add(new ListItem(x)));

            ////动态绑定日志类别,根据数据库
            //info_CategoryName(ddlDatabaseName.SelectedValue);
        }

        /// <summary>
        /// 动态绑定日志类别,根据数据库
        /// </summary>
        protected void info_CategoryName(string DatabaseName)
        {
            if (DatabaseName != "0")
            {
                //string AppName = DatabaseName.Substring(0, DatabaseName.Length - 6);
                //ddlMachineIP.Items.Clear();
                //ddlMachineIP.Items.Add(new ListItem("请选择服务器IP", "0"));
                //DomainIPPageService.GetAllMachineIPData(AppName, "LogInfo").ForEach(x => ddlMachineIP.Items.Add(new ListItem(x)));
                //ddlPageUrl.Items.Clear();
                //ddlPageUrl.Items.Add(new ListItem("请选择页面地址", "0"));
                //DomainIPPageService.GetAllPageNameData(AppName, "LogInfo").ForEach(x => ddlPageUrl.Items.Add(new ListItem(x)));

                ////日志类别
                //ddlCategoryName.Items.Clear();
                //ddlCategoryName.Items.Add(new ListItem("请选择日志类别", "0"));
                //PublicInfoService.GetAllDistinctData("appinfocenter", "LogInfoModel", "CategoryName", new Document().Append("AppName", AppName)).ForEach(x => ddlCategoryName.Items.Add(new ListItem(x)));
            }
        }


        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btSearch_Click(object sender, EventArgs e)
        {
            info_show();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            info_show();
        }



        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btShouye_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            info_show();
        }

        //上一页
        protected void btShangyiye_Click(object sender, EventArgs e)
        {
            if (PageIndex > 1)
            {
                PageIndex = PageIndex - 1;
                info_show();
            }
        }

        //下一页
        protected void btXiayiye_Click(object sender, EventArgs e)
        {

            PageIndex = PageIndex + 1;
            info_show();
        }


    }
}