using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.ProjectManage;
using System.Collections;
using System.Data;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IProjectPlanManageService
    {
        /// <summary>
        /// 创建产品配置,并获取编号
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [OperationContract]
        string createProductDeploy(Product product);
        /// <summary>
        /// 获取任务树和任务执行状态
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<TaskTree> getTaskTree();
        /// <summary>
        /// 获取甘特图日历
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        DateTime[] getGanttCalendar(int projectid);
        /// <summary>
        /// 添加项目多文档
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool addProjectDocument();
        /// <summary>
        /// 保存项目任务
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool saveTask(TaskBo task);
        /// <summary>
        /// 获取用户组,根据项目编号获取项目组成员
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [OperationContract]
        List<ProjectGroupUser> getProjectGroupUsersByIdProjectId(int projectId);
        /// <summary>
        /// 获取所有任务,根据项目编号获取任务
        /// </summary>
        /// <param name="projectid"></param>
        /// <returns></returns>
        [OperationContract]
        List<TaskBo> getTasksByProjectId(int projectid);
        /// <summary>
        /// 获取用户任务,根据用户编号获取任务
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [OperationContract]
        List<TaskBo> getTasksByUserId(int userid);
    }
}
