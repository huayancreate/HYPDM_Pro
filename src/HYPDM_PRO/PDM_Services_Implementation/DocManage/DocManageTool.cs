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
    public class DocManageTool : IDocManageTool
    {
        #region 文档管理器 
        /// <summary>
        /// 文档管理器查询文档
        /// </summary>
        /// <returns></returns>
        public List<document> getDocument(document doc)
        {
            document D1 = new document();
            D1.cn_name = "文档1";
            D1.create_user_name = "李俊";
            D1.dense_name = "绝密";
            D1.valid_time = "2013-01-12";
            D1.remark = "备注";
            D1.status = "有效";
            D1.format_name = "doc";
            D1.version = "0001";

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

            List<document> list = new List<document>();
            list.Add(D1);
            list.Add(D2);
            return list;
        }



        /// <summary>
        /// 查询所有的文档树
        /// </summary>
        /// <returns></returns>
        public List<document_tree> getAllDocumentTree()
        {
            List<document_tree> docTlist = new List<document_tree>();
            document_tree t1 = new document_tree();
            t1.id = 1;
            t1.name = "文档树";
            t1.parent_id = -1;

            document_tree t2 = new document_tree();
            t2.id = 2;
            t2.name = "项目文档";
            t2.parent_id = 1;

            document_tree t3 = new document_tree();
            t3.id = 3;
            t3.name = "文件夹";
            t3.parent_id = 1;

            document_tree t4 = new document_tree();
            t4.id = 4;
            t4.name = "文件夹1";
            t4.parent_id = 3;

            docTlist.Add(t1);
            docTlist.Add(t2);
            docTlist.Add(t3);
            docTlist.Add(t4);

            return docTlist;
        }

        /// <summary>
        /// 查询所有的文档,构建文档树
        /// </summary>
        /// <returns></returns>
        public List<document> getAllDocument()
        {
            List<document> doclist = new List<document>();
            document D2 = new document();
            D2.cn_name = "文档3";
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
            D2.format_name = "xls";
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
            D2.document_type_id = 3;
            D2.physical_file_location = "g:\\12.xls";

            document D3 = new document();
            D3.cn_name = "文档2";
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
            D3.format_name = "xls";
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
            D3.document_type_id = 3;
            D3.physical_file_location = "g:\\11.xls";
            doclist.Add(D2);
            doclist.Add(D3);

            return doclist;
        }


        /// <summary>
        /// 创建文档分类 
        /// </summary>
        /// <returns></returns>
        public document_tree addDocumentTree(document_tree docT)
        {
            return docT;
        }

        /// <summary>
        /// 修改文档分类
        /// </summary>
        /// <returns></returns>
        public document_tree updateDocumentTree(document_tree docT)
        {
            return docT;
        }

        /// <summary>
        /// 删除文档分类
        /// </summary>
        /// <returns></returns>
        public bool delDocumentTree(document_tree docT)
        {
            return true;
        }

        #endregion

        #region 对文档操作

        /// <summary>
        /// 查询关联文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public List<document> getSubDocument(document doc)
        {
            document d = new document();
            d.number = "111111";
            d.cn_name = "文档1";
            d.version = "00";
            d.document_type_name = "A1";
            document d1 = new document();
            d1.number = "2222";
            d1.cn_name = "文档2";
            d1.version = "01";
            d1.document_type_name = "B1";
            List<document> list = new List<document>();
            list.Add(d);
            list.Add(d1);
            return list;
        }

        /// <summary>
        /// 插入文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public document insertDocument(document doc)
        {
            String filePath = @"g:\";
            Random rand = new Random();
            string newfilename = filePath + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "m" +
             DateTime.Now.Day.ToString() + "d"   + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString()
            + DateTime.Now.Millisecond.ToString()  + "a" + rand.Next(1000).ToString() + doc.cn_name+"." + doc.format_name;
            doc.ipaddress = "127.0.0.1";
            doc.port = 7775;
            // 插入数据库
            return doc;
        }


        /// <summary>
        /// 批量插入文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public List<document> insertDocuments(List<document> docList)
        {
            return docList;
        }
        

        /// <summary>
        /// 更新文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public document updateDocument(document doc)
        {
            return doc;
        }

        /// <summary>
        /// 删除文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public bool delDocument(document doc)
        {
            return true;
        }

        /// <summary>
        /// 下载文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public bool downDocument(document doc)
        {
            // 获取后台文件，发送到前台
            Client client = new Client(doc.ipaddress,doc.port,doc.cn_name+"."+doc.format_name,doc.physical_file_location);
            //client.start();
            client.StartSend();
            return true;
        }

        /// <summary>
        /// 批量下载文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public bool downDocumentAll(List<document> docs)
        {
            foreach(document doc in docs){
                // 获取后台文件，发送到前台
                Client client = new Client(doc.ipaddress, doc.port, doc.cn_name + "." + doc.format_name, doc.physical_file_location);
                client.StartSend();
            }
            return true;
        }


        /// <summary>
        /// 根据doc的key，查询出doc详细信息（零件/包含文档）
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public document getDocumentByKey(document doc)
        {
            document d = new document();
            d.number = "111111";
            d.cn_name = "文档1";
            d.version = "00";
            d.document_type_name = "A1";
            document d1 = new document();
            d1.number = "2222";
            d1.cn_name = "文档2";
            d1.version = "01";
            d1.document_type_name = "B1";
            List<document> list = new List<document>();
            list.Add(d);
            list.Add(d1);
            doc.sub_document = list;
            return doc;
        }

        #endregion

        /***
        #region 对文档扩展属性操作
        /// <summary>
        /// 根据文档属性来查询文档属性
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        public document_type getDocumentColumnByType(document_type docType)
        {
            //根据文档类型，查找文档的属性
            document_type type = new document_type();
            doc_attached_property p1 = new doc_attached_property();
            p1.cn_name = "";
            p1.en_name = "";

            return type;
        }

        /// <summary>
        /// 根据文档类型，查询文档的扩展属性
        /// </summary>
        /// <returns></returns>
        public document_type getDocumentProperty(document doc)
        {
            document_type doctype = new document_type();
            List<doc_attached_property> docProList = new List<doc_attached_property>();
            doc_attached_property dp1 = new doc_attached_property();
            dp1.en_name = "Docdep";
            dp1.cn_name = "文档部门";
            dp1.is_user_define = "";
            dp1.is_display = true;
            dp1.display_width = "100";
            dp1.input_type = "";
            dp1.data_type = "字符型";
            dp1.default_value = "测试001";
            dp1.data_length = "100";
            dp1.order = "1";
            docProList.Add(dp1);
            doc_attached_property dp2 = new doc_attached_property();
            dp2.en_name = "wordsize";
            dp2.cn_name = "文档大小";
            dp2.is_user_define = "";
            dp2.is_display = true;
            dp2.display_width = "100";
            dp2.data_type = "数值型";
            dp2.default_value = "测试002";
            dp2.data_length = "80";
            dp2.order ="2";
            docProList.Add(dp2);
            /***
            DocProperty dp3 = new DocProperty();
            dp3.EnName = "column3";
            dp3.CnName = "文档名称";
            dp3.IsUserDefine = "";
            dp3.IsDisplay = true;
            dp3.Width = "100";
            dp3.DataType = "日期型";
            dp3.Default = "测试003";
            dp3.DataLength = "120";
            dp3.Order = 3;
            doc.Add(dp3);*
            doc_attached_property dp4 = new doc_attached_property();
            dp4.en_name = "column4";
            dp4.cn_name = "文档扩展属性1";
            dp4.is_user_define = "是";
            dp4.is_display = true;
            dp4.display_width = "100";
            dp4.order = "4";
            dp4.input_type = "SEL";

            List<doc_combobox_value> selectvlaue = new List<doc_combobox_value>();
            doc_combobox_value v1 = new doc_combobox_value();
            v1.value = "1000";
            doc_combobox_value v2 = new doc_combobox_value();
            v2.value = "2000";
            selectvlaue.Add(v1);
            selectvlaue.Add(v2);
            dp4.ComboxValue = selectvlaue;
            docProList.Add(dp4);
            doctype.DocProperty = docProList;
            return doctype;
        }

        /// <summary>
        /// 插入文档属性
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        public bool insertDocProperty(document_type docType)
        {
            // 根据docType中属性集合，插入更新到数据库。
            return true;
        }
        #endregion 

        #region  文档模板管理

        /// <summary>
        ///  获取所有文档模板树
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        public List<doc_template_tree> getAllDocumentTemplateTree()
        {
            List<doc_template_tree> docTemplateTree = new List<doc_template_tree>();
            doc_template_tree DOC = new doc_template_tree();
            DOC.id = 1;
            DOC.name = "设计文档";
            DOC.parent_id = -1;

            docTemplateTree.Add(DOC);
            doc_template_tree DOC1 = new doc_template_tree();
            DOC1.id = 2;
            DOC1.name = "办公文档";
            DOC1.parent_id = -1;
            docTemplateTree.Add(DOC1);

            return docTemplateTree;
        }

        /// <summary>
        /// 获取所有的文档模板
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        public List<doc_template> getAllDocumentTemplate()
        {
            List<doc_template> docTemplateList = new List<doc_template>();
            doc_template DOC2 = new doc_template();
            DOC2.id = 3;
            DOC2.name = "需求文档模板";
            DOC2.parent_id = 1;
            DOC2.parent_name = "设计文档";
            DOC2.breadth = "A4";
            DOC2.create_date = DateTime.Parse("2013-01-01");
            DOC2.create_user_name = "李俊";
            DOC2.create_user_id = 1;
            DOC2.modify_date = DateTime.Parse("2013-01-01");
            DOC2.modify_user_id = 2;
            DOC2.modify_user_name = "张三";
            DOC2.modify_count = "2";
            docTemplateList.Add(DOC2);
            return docTemplateList;
        }


        /// <summary>
        /// 插入文档模板文件夹
        /// </summary>
        /// <param name="docTemplateTree"></param>
        /// <returns></returns>
        public doc_template_tree insertDocumentTemplateTree(doc_template_tree docTemplateTree)
        {
            return docTemplateTree;
        }

        /// <summary>
        /// 更新文档模板文件夹
        /// </summary>
        /// <param name="docTemplateTree"></param>
        /// <returns></returns>
        public doc_template_tree updateDocumentTemplateTree(doc_template_tree docTemplateTree)
        {
            return docTemplateTree;
        }

        /// <summary>
        /// 删除文档模板文件夹
        /// </summary>
        /// <returns></returns>
        public bool delDocumentTemplateTree(doc_template_tree docTemplateTree)
        {
            return true;
        }

        /// <summary>
        /// 插入文档模板
        /// </summary>
        /// <param name="docTemplate"></param>
        /// <returns></returns>
        public doc_template insertDocumentTemplate(doc_template docTemplate)
        {
            return docTemplate;
        }

        /// <summary>
        /// 修改文档模板
        /// </summary>
        /// <param name="docTemplate"></param>
        /// <returns></returns>
        public doc_template updateDocumentTemplate(doc_template docTemplate)
        {
            return docTemplate;
        }

        /// <summary>
        /// 删除文档模板
        /// </summary>
        /// <param name="docTemplate"></param>
        /// <returns></returns>
        public bool delDocumentTemplate(doc_template docTemplate)
        {
            return true;
        }

        #endregion 

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


        #region  文档密级

        /// <summary>
        /// 查询所有的文档密级
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        public List<dense> getAllDense()
        {
            List<dense> denseList = new List<dense>();
            dense d1 = new dense();
            d1.id = 1;
            d1.name = "绝密";
            dense d2 = new dense();
            d2.id = 2;
            d2.name = "机密";
            dense d3 = new dense();
            d3.id = 3;
            d3.name = "秘密";
            dense d4 = new dense();
            d4.id = 4;
            d4.name = "一般";
            denseList.Add(d1);
            denseList.Add(d2);
            denseList.Add(d3);
            denseList.Add(d4);
            return denseList;
        }

        /// <summary>
        /// 查询所有的文档密级关系
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        public List<dense_role> getAllDenseRole()
        {
            List<dense_role> denseRoleList = new List<dense_role>();
            dense_role den1 = new dense_role();
            den1.dense_id = 1;
            den1.role_id = 1;
            den1.role_name = "系统管理员角色";

            dense_role den2 = new dense_role();
            den2.dense_id = 1;
            den2.role_id = 2;
            den2.role_name = "工艺系统";

            dense_role den3 = new dense_role();
            den3.dense_id = 2;
            den3.role_id = 3;
            den3.role_name = "系统集成";

            dense_role den4 = new dense_role();
            den4.dense_id = 2;
            den4.role_id = 4;
            den4.role_name = "文档管理";

            dense_role den5 = new dense_role();
            den5.dense_id = 3;
            den5.role_id = 5;
            den5.role_name = "系统管理员角色";

            dense_role den6 = new dense_role();
            den6.dense_id = 4;
            den6.role_id = 1;
            den6.role_name = "系统管理员角色";

            dense_role den7 = new dense_role();
            den7.dense_id = 4;
            den7.role_id = 7;
            den7.role_name = "变更管理";

            dense_role den8 = new dense_role();
            den8.dense_id = 4;
            den8.role_id = 8;
            den8.role_name = "项目管理";

            denseRoleList.Add(den1);
            denseRoleList.Add(den2);
            denseRoleList.Add(den3);
            denseRoleList.Add(den4);
            denseRoleList.Add(den5);
            denseRoleList.Add(den6);
            denseRoleList.Add(den7);
            denseRoleList.Add(den8);
            return denseRoleList;
        }

        #endregion 
        **/

    }
}
