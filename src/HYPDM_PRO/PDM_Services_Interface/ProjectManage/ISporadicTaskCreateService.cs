using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.ProjectManage;
using System.Collections;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface ISporadicTaskCreateService
    {
        /// <summary>
        /// 获取所有任务类型
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<TaskTypebo> getAllTaskTypes();
        /// <summary>
        /// 保存设计任务
        /// </summary>
        /// <param name="hashtable"></param>
        /// <returns></returns>
        [OperationContract]
        bool saveProjectTask(Hashtable hashtable);
        /// <summary>
        /// 保存办公任务
        /// </summary>
        /// <param name="hashtable"></param>
        /// <returns></returns>
        [OperationContract]
        bool saveOfficeTask(Hashtable hashtable);
        /// <summary>
        /// 保存工艺任务
        /// </summary>
        /// <param name="hashtable"></param>
        /// <returns></returns>
        [OperationContract]
        bool saveTechnologyTask(Hashtable hashtable);
    }
}
