using PDM_Services_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using PDM_Entity.DocManage;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading; 

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class DocGrantManage : IDocGrantManage
    {

        #region 文档发放管理

        /// <summary>
        /// 查询需要发放的文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public List<document> scanDocumentWithGrant(document doc)
        {
            document D1 = new document();
            D1.id = 1;
            D1.cn_name = "文档1";
            D1.number = "233333";
            D1.create_user_name = "李俊";
            D1.dense_name = "绝密";
            D1.valid_time = "2013-01-12";
            D1.remark = "备注";
            D1.status = "有效";
            D1.format_name = "doc";
            D1.document_type_name = "文档1";
            D1.document_type_id = 111;
            D1.version = "0001";
            D1.gridControlCheck = false;

            document D2 = new document();
            D2.id = 2;
            D2.cn_name = "文档2";
            D1.number = "44444";
            D2.create_user_name = "李俊1";
            D2.create_date = DateTime.Parse("2013-01-01");
            D2.modify_count = "0";
            D2.modify_date = DateTime.Parse("2013-01-01");
            D2.modify_user_name = "李俊1";
            D2.doc_page = "A4";
            D2.dense_name = "保密";
            D2.valid_time = "2013-01-01";
            D2.in_valid_time = "2013-01-12";
            D2.remark = "备注";
            D2.status = "有效";
            D2.format_name = "txt";
            D2.version = "0002";
            D2.abstract_content = "备注";
            D2.en_name = "wendang2";
            D2.number = "00002";
            D2.key = "文档  设计文档  车轮";
            D2.doc_template_id = 1;
            D2.doc_template_name = "需求设计文档";
            D2.column1 = "12";
            D2.column2 = "23";
            D2.column3 = "34";
            D2.gridControlCheck = false;

            List<document> list = new List<document>();
            list.Add(D1);
            list.Add(D2);
            return list;
        }

        /// <summary>
        /// 查看文档发放设置
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        public List<doc_grant_setting> getGrantSetting(doc_grant_setting doc_grant)
        {
            List<doc_grant_setting> grantSetting = new List<doc_grant_setting>();

            doc_grant_setting dg1 = new doc_grant_setting();
            dg1.id = 1;
            dg1.grant_by_user = "李俊";
            dg1.grant_type = "人员";
            dg1.grant_user = "张三";
            dg1.in_valid_time = "2013-01-02";
            dg1.valid_time = "2013-01-01";
            dg1.permission_type_name = "控件浏览";
            dg1.valid = "1";
            grantSetting.Add(dg1);

            doc_grant_setting dg2 = new doc_grant_setting();
            dg2.id = 1;
            dg2.grant_by_user = "李俊";
            dg2.grant_type = "人员";
            dg2.grant_user = "李四";
            dg2.in_valid_time = "2013-01-02";
            dg2.valid_time = "2013-01-01";
            dg2.permission_type_name = "控件浏览";
            dg2.valid = "1";
            grantSetting.Add(dg2);

            document D2 = new document();
            D2.cn_name = "文档2";
            D2.create_user_name = "李俊1";
            D2.create_date = DateTime.Parse("2013-01-01");
            D2.modify_count = "0";
            D2.modify_date = DateTime.Parse("2013-01-01");
            D2.modify_user_name = "李俊1";
            D2.doc_page = "A4";
            D2.dense_name = "保密";
            D2.valid_time = "2013-01-01";
            D2.in_valid_time = "2013-01-12";
            D2.remark = "备注";
            D2.status = "有效";
            D2.format_name = "txt";
            D2.version = "0002";
            D2.abstract_content = "备注";
            D2.en_name = "wendang2";
            D2.number = "00002";
            D2.key = "文档  设计文档  车轮";
            D2.doc_template_id = 1;
            D2.doc_template_name = "需求设计文档";
            D2.column1 = "12";
            D2.column2 = "23";
            D2.column3 = "34";

            List<document> docList = new List<document>();
            docList.Add(D2);
            dg1.document_list = docList;

            document D3 = new document();
            D3.cn_name = "文档3";
            D3.create_user_name = "李俊1";
            D3.create_date = DateTime.Parse("2013-01-01");
            D3.modify_count = "0";
            D3.modify_date = DateTime.Parse("2013-01-01");
            D3.modify_user_name = "李俊1";
            D3.doc_page = "A4";
            D3.dense_name = "保密";
            D3.valid_time = "2013-01-01";
            D3.in_valid_time = "2013-01-12";
            D3.remark = "备注";
            D3.status = "有效";
            D3.format_name = "txt";
            D3.version = "0002";
            D3.abstract_content = "备注";
            D3.en_name = "wendang2";
            D3.number = "00002";
            D3.key = "文档  设计文档  车轮";
            D3.doc_template_id = 1;
            D3.doc_template_name = "需求设计文档";
            D3.column1 = "12";
            D3.column2 = "23";
            D3.column3 = "34";

            List<document> docList1 = new List<document>();
            docList1.Add(D3);
            dg2.document_list = docList1;

            return grantSetting;
        }


        /// <summary>
        /// 查看文档发放设置
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        public List<doc_grant_setting> getGrantSettingByDoc(document doc)
        {
            List<doc_grant_setting> grantSetting = new List<doc_grant_setting>();

            doc_grant_setting dg1 = new doc_grant_setting();
            dg1.id = 1;
            dg1.grant_by_user = "李俊";
            dg1.grant_type = "人员";
            dg1.grant_user = "张三";
            dg1.in_valid_time = "2013-01-02";
            dg1.valid_time = "2013-01-01";
            dg1.permission_type_name = "控件浏览";
            dg1.valid = "1";
            grantSetting.Add(dg1);

            doc_grant_setting dg2 = new doc_grant_setting();
            dg2.id = 1;
            dg2.grant_by_user = "李俊";
            dg2.grant_type = "人员";
            dg2.grant_user = "李四";
            dg2.in_valid_time = "2013-01-02";
            dg2.valid_time = "2013-01-01";
            dg2.permission_type_name = "控件浏览";
            dg2.valid = "1";
            grantSetting.Add(dg2);

            document D2 = new document();
            D2.cn_name = "文档2";
            D2.create_user_name = "李俊1";
            D2.create_date = DateTime.Parse("2013-01-01");
            D2.modify_count = "0";
            D2.modify_date = DateTime.Parse("2013-01-01");
            D2.modify_user_name = "李俊1";
            D2.doc_page = "A4";
            D2.dense_name = "保密";
            D2.valid_time = "2013-01-01";
            D2.in_valid_time = "2013-01-12";
            D2.remark = "备注";
            D2.status = "有效";
            D2.format_name = "txt";
            D2.version = "0002";
            D2.abstract_content = "备注";
            D2.en_name = "wendang2";
            D2.number = "00002";
            D2.key = "文档  设计文档  车轮";
            D2.doc_template_id = 1;
            D2.doc_template_name = "需求设计文档";
            D2.column1 = "12";
            D2.column2 = "23";
            D2.column3 = "34";

            List<document> docList = new List<document>();
            docList.Add(D2);
            dg1.document_list = docList;

            document D3 = new document();
            D3.cn_name = "文档3";
            D3.create_user_name = "李俊1";
            D3.create_date = DateTime.Parse("2013-01-01");
            D3.modify_count = "0";
            D3.modify_date = DateTime.Parse("2013-01-01");
            D3.modify_user_name = "李俊1";
            D3.doc_page = "A4";
            D3.dense_name = "保密";
            D3.valid_time = "2013-01-01";
            D3.in_valid_time = "2013-01-12";
            D3.remark = "备注";
            D3.status = "有效";
            D3.format_name = "txt";
            D3.version = "0002";
            D3.abstract_content = "备注";
            D3.en_name = "wendang2";
            D3.number = "00002";
            D3.key = "文档  设计文档  车轮";
            D3.doc_template_id = 1;
            D3.doc_template_name = "需求设计文档";
            D3.column1 = "12";
            D3.column2 = "23";
            D3.column3 = "34";

            List<document> docList1 = new List<document>();
            docList1.Add(D3);
            dg2.document_list = docList1;

            return grantSetting;
        }


        /// <summary>
        /// 插入文档发放设置
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        public doc_grant_setting insertGrantSetting(doc_grant_setting doc_grant)
        {
            return doc_grant;
        }

        #endregion     

    }
}
