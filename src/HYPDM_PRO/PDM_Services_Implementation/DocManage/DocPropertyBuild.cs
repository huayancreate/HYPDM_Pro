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
    public class DocPropertyBuild : IDocPropertyBuild
    {
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
            dp2.order = "2";
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
            doc.Add(dp3);**/
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
    }
}
