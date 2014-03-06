using PDM_Entity.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using PDM_Entity.DocManage;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IDocTemplateCategoryManage
    {
        #region  文档模板管理

        /// <summary>
        ///  获取所有文档模板树
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        [OperationContract]
        List<doc_template_tree> getAllDocumentTemplateTree();

        /// <summary>
        /// 获取所有的文档模板
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        [OperationContract]
        List<doc_template> getAllDocumentTemplate();

        /// <summary>
        /// 插入文档模板文件夹
        /// </summary>
        /// <param name="docTemplateTree"></param>
        /// <returns></returns>
        [OperationContract]
        doc_template_tree insertDocumentTemplateTree(doc_template_tree docTemplateTree);

        /// <summary>
        /// 更新文档模板文件夹
        /// </summary>
        /// <param name="docTemplateTree"></param>
        /// <returns></returns>
        [OperationContract]
        doc_template_tree updateDocumentTemplateTree(doc_template_tree docTemplateTree);

        /// <summary>
        /// 删除文档模板文件夹
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool delDocumentTemplateTree(doc_template_tree docTemplateTree);

        /// <summary>
        /// 插入文档模板
        /// </summary>
        /// <param name="docTemplate"></param>
        /// <returns></returns>
        [OperationContract]
        doc_template insertDocumentTemplate(doc_template docTemplate);

        /// <summary>
        /// 修改文档模板
        /// </summary>
        /// <param name="docTemplate"></param>
        /// <returns></returns>
        [OperationContract]
        doc_template updateDocumentTemplate(doc_template docTemplate);

        /// <summary>
        /// 删除文档模板
        /// </summary>
        /// <param name="docTemplate"></param>
        /// <returns></returns>
        [OperationContract]
        bool delDocumentTemplate(doc_template docTemplate);

        #endregion 


    }
}
