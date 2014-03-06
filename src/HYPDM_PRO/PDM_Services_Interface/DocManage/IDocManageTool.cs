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
    public interface IDocManageTool
    {
        #region  文档管理器
        /// <summary>
        /// 根据条件，查询文档
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<document> getDocument(document doc);

        /// <summary>
        /// 查询所有文件夹，构建文档树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<document_tree> getAllDocumentTree();

        /// <summary>
        /// 查询所有文档，构建文档树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<document> getAllDocument();

        /// <summary>
        /// 创建文档分类 
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        document_tree addDocumentTree(document_tree docT);

        /// <summary>
        /// 修改文档分类
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        document_tree updateDocumentTree(document_tree docT);

        /// <summary>
        /// 删除文档分类
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool delDocumentTree(document_tree docT);

        #endregion 


        #region  文档操作
        /// <summary>
        /// 查询关联文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        List<document> getSubDocument(document doc);

        /// <summary>
        /// 根据文档key,查询文档的所有信息（零件、包含文档等）
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        document getDocumentByKey(document doc);

        /// <summary>
        /// 插入文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        document insertDocument(document doc);

        /// <summary>
        /// 批量插入文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        List<document> insertDocuments(List<document> docList);

        /// <summary>
        /// 更新文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        document updateDocument(document doc);

        /// <summary>
        /// 删除文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        bool delDocument(document doc);

        /// <summary>
        /// 下载文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        bool downDocument(document doc);

        /// <summary>
        /// 批量下载文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        bool downDocumentAll(List<document> doc);


        #endregion 


        /***
        #region  文档扩展属性

        /// <summary>
        /// 
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        [OperationContract]
        document_type getDocumentColumnByType(document_type docType);

        /// <summary>
        /// 根据文档类型，查询文档的扩展属性
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        document_type getDocumentProperty(document doc);

        /// <summary>
        /// 插入文档属性
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        [OperationContract]
        bool insertDocProperty(document_type docType);
        #endregion 


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


        #region 文档发放管理

        /// <summary>
        /// 查询需要发放的文档
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [OperationContract]
        List<document> scanDocumentWithGrant(document doc);

        /// <summary>
        /// 查看文档发放设置
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        [OperationContract]
        List<doc_grant_setting> getGrantSetting(doc_grant_setting doc_grant);

        /// <summary>
        /// 查看文档发放设置
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        [OperationContract]
        List<doc_grant_setting> getGrantSettingByDoc(document doc);

        /// <summary>
        /// 插入文档发放设置
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        [OperationContract]
        doc_grant_setting insertGrantSetting(doc_grant_setting doc_grant);

        #endregion 

        #region  文档密级

        /// <summary>
        /// 查询所有的文档密级
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        [OperationContract]
        List<dense> getAllDense();

        /// <summary>
        /// 查询所有的文档密级关系
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        [OperationContract]
        List<dense_role> getAllDenseRole();

        #endregion 
         * ***/

    }
}
