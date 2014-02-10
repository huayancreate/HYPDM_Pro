using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using WcfExtension.LogCenter.Core;
using System.Text;
using System.Collections;

namespace WcfExtension.LogCenter.Info
{
    public partial class LogDetail : System.Web.UI.Page
    {
   
        public string locationid = "";
        public string httpid = "";
        public string requestid = "";

        string infoid = "";
        public string dbName = "";
        public string collectionName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                infoid = Request.QueryString["id"];
            }

            if (Request.QueryString["dbname"] != null)
            {
                dbName = Request.QueryString["dbname"];
            }
            if (Request.QueryString["tablename"] != null)
            {
                collectionName = Request.QueryString["tablename"];
            }

            if (!IsPostBack)
            {
                info_show(infoid);
            }
        }


        protected void info_show(string myId)
        {
            if (string.IsNullOrEmpty(dbName)) return;
            liDbName.Text = "<b>Database</b>：" + dbName + " <b>Table</b>：" + collectionName;
            BsonDocument where = new BsonDocument();
            where.Add("ID", myId);
            AbstractLogInfo model = null;
            if (collectionName == "ClientExceptionInfo")
            {
                model = MongoDBUtil.GetModel<ClientExceptionInfo>(dbName, collectionName, where);
            }
            else if (collectionName == "ClientInvokeInfo")
            {
                model = MongoDBUtil.GetModel<ClientInvokeInfo>(dbName, collectionName, where);

            }
            else if (collectionName == "ClientMessageInfo")
            {
                model = MongoDBUtil.GetModel<ClientMessageInfo>(dbName, collectionName, where);
            }
            else if (collectionName == "ServerExceptionInfo")
            {
                model = MongoDBUtil.GetModel<ServerExceptionInfo>(dbName, collectionName, where);
            }
            else if (collectionName == "ServerInvokeInfo")
            {
                model = MongoDBUtil.GetModel<ServerInvokeInfo>(dbName, collectionName, where);
            }
            else if (collectionName == "ServerMessageInfo")
            {
                model = MongoDBUtil.GetModel<ServerMessageInfo>(dbName, collectionName, where);
            }
            else if (collectionName == "ClientStartInfo")
            {
                model = MongoDBUtil.GetModel<ClientStartInfo>(dbName, collectionName, where);
            }
            else if (collectionName == "ServerStartInfo")
            {
                model = MongoDBUtil.GetModel<ServerStartInfo>(dbName, collectionName, where);
            }
            if (model != null)
            {
                requestid = model.RequestIdentity.ToString();
                StringBuilder sb = new StringBuilder();
                model.GetType().GetProperties().ToList().ForEach(p =>
                {
                    var o = p.GetValue(model, null);
                    var data = new StringBuilder();
                    if (o is Dictionary<string, string>)
                    {
                        data.AppendLine("<table cellpadding='3'>");
                        var dic = o as Dictionary<string, string>;
                        foreach (var key in dic)
                        {
                            data.AppendLine(string.Format("<tr><td><i>{0}</i></td><td>{1}</td></tr>", key.Key, key.Value));
                        }
                        data.AppendLine("</table>");
                    }
                    else if (o is IList)
                    {
                        var list = o as IList;
                        foreach(var item in list)
                           data.AppendLine(item.ToString() + " , ");
                    }
                    else if (o is WcfClientEndpoint)
                    {
                        data.AppendLine("<table cellpadding='3'>");
                        o.GetType().GetProperties().ToList().ForEach(pp =>
                        {
                            data.AppendLine(string.Format("<tr><td><i>{0}</i></td><td>{1}</td></tr>", pp.Name, Server.HtmlEncode(pp.GetValue(o, null) == null ? "" : pp.GetValue(o, null).ToString()).Replace(Environment.NewLine, "<br/>").Replace(" ", "&nbsp;")));
                          
                        });
                        data.AppendLine("</table>");
                    }
                    else if (o is WcfService)
                    {
                        data.AppendLine("<table cellpadding='3'>");
                        o.GetType().GetProperties().ToList().ForEach(pp =>
                        {
                            var value = pp.GetValue(o, null);
                            if (value is IList)
                            {
                                data.AppendLine("<tr><td>" + value +"</td><td>");
                                var list = value as IList;
                                foreach (var item in list)
                                {
                                    data.AppendLine("<table cellpadding='3'>");
                                    item.GetType().GetProperties().ToList().ForEach(ppp =>
                                    {
                                        data.AppendLine(string.Format("<tr><td><i>{0}</i></td><td>{1}</td></tr>", ppp.Name, Server.HtmlEncode(ppp.GetValue(item, null) == null ? "" : ppp.GetValue(item, null).ToString()).Replace(Environment.NewLine, "<br/>").Replace(" ", "&nbsp;")));

                                    });
                                    data.AppendLine("</table>");
                                }
                                data.AppendLine("</td></tr>");
                            }
                            else
                            {
                                data.AppendLine(string.Format("<tr><td><i>{0}</i></td><td>{1}</td></tr>", pp.Name, Server.HtmlEncode(value == null ? "" : value.ToString()).Replace(Environment.NewLine, "<br/>").Replace(" ", "&nbsp;")));
                            }

                        });
                        data.AppendLine("</table>");
                    }
                    else
                    {
                        data.AppendLine(Server.HtmlEncode(o.ToString()).Replace(Environment.NewLine, "<br/>").Replace(" ", "&nbsp;"));
                    }

                    sb.AppendLine(string.Format("<tr><td>&nbsp;</td><td><strong>{0}</strong></td><td>{1}</td></tr>", p.Name, data == null ? "" : data.ToString()));
                                      

                });
                liContent.Text = sb.ToString();
            }

        }
    }
}