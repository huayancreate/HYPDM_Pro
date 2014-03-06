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
    public interface IDocSecurityLevelBuild
    {
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

    }
}
