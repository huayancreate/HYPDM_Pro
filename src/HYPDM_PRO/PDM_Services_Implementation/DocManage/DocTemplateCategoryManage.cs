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
    public class DocTemplateCategoryManage : IDocTemplateCategoryManage
    {

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
    
    }
}
