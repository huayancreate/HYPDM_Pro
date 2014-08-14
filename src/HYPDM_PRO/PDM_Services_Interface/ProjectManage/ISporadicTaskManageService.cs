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
    public interface ISporadicTaskManageService
    {
        /// <summary>
        /// 获取零星任务列表,根据选定是否能分解/创建人/执行人/任务状态和时间获取零星任务列表.
        /// </summary>
        /// <param name="Conditions"></param>
        /// <returns></returns>
        [OperationContract]
        List<TaskBo> getSporadicTaskBySomeConditions(Hashtable Conditions);
        /// <summary>
        /// 获取零星任务,根据零星任务编号获取零星任务
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [OperationContract]
        TaskBo getSporadicTaskById(int id);
        /// <summary>
        /// 获取零星任务树列表,根据选定是否能分解/创建人/执行人/任务状态和时间获取零星任务树列表.
        /// </summary>
        /// <param name="Conditions"></param>
        /// <returns></returns>
        [OperationContract]
        List<TaskTree> getTaskTreeBySomeConditions(Hashtable Conditions);
        /// <summary>
        /// 删除零星任务,根据零星任务编号删除零星任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool removeSporadicTaskById(int id);
    }
}
