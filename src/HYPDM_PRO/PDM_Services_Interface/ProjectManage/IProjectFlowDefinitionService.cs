using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Entity.ProjectManage;
using System.ServiceModel;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IProjectFlowDefinitionService
    {
        /// <summary>
        /// 获取所有项目流程
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<ProjectProcessbo> getAllProjectProcess();
        /// <summary>
        /// 获取项目流程,根据用户编号获取项目流程
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [OperationContract]
        List<ProjectProcessbo> getProjectProcessByUserId(int userid);
    }
}
