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
    public interface IDocGrantManage
    {

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

    }
}
