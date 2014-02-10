using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using WcfExtension.LogCenter.Core;

namespace WcfExtension.LogCenter.Info
{
    public partial class NewHttpRequest : System.Web.UI.Page
    {
        string infoid = "";
        public string dbName = "";
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
            if (!IsPostBack)
            {
                info_show();
            }
        }

        protected void info_show()
        {

            #region 条件
            BsonDocument where = new BsonDocument();
            where.Add("RequestIdentity", infoid);
            #endregion

            #region 排序
            string[] orderby = { "Time" };
            #endregion

            #region 字段
            BsonDocument fields = new BsonDocument();
            #endregion

            //查询数据库

            List<ClientExceptionInfo> list1 = MongoDBUtil.GetPaged<ClientExceptionInfo>(dbName, "ClientExceptionInfo", where, orderby, fields, 1, 20);
            Repeater1.DataSource = list1;
            Repeater1.DataBind();


            List<ClientInvokeInfo> list2 = MongoDBUtil.GetPaged<ClientInvokeInfo>(dbName, "ClientInvokeInfo", where, orderby, fields, 1, 20);
            Repeater2.DataSource = list2;
            Repeater2.DataBind();


            List<ClientMessageInfo> list3 = MongoDBUtil.GetPaged<ClientMessageInfo>(dbName, "ClientMessageInfo", where, orderby, fields, 1, 20);
            Repeater3.DataSource = list3;
            Repeater3.DataBind();

            List<ServerExceptionInfo> list4 = MongoDBUtil.GetPaged<ServerExceptionInfo>(dbName, "ServerExceptionInfo", where, orderby, fields, 1, 20);
            Repeater4.DataSource = list4;
            Repeater4.DataBind();

            List<ServerInvokeInfo> list5 = MongoDBUtil.GetPaged<ServerInvokeInfo>(dbName, "ServerInvokeInfo", where, orderby, fields, 1, 20);
            Repeater5.DataSource = list5;
            Repeater5.DataBind();

            List<ServerMessageInfo> list6 = MongoDBUtil.GetPaged<ServerMessageInfo>(dbName, "ServerMessageInfo", where, orderby, fields, 1, 20);
            Repeater6.DataSource = list6;
            Repeater6.DataBind();


        }
    }
}