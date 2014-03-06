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
    public interface IDocPropertyBuild
    {

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


    }
}
