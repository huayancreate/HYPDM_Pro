using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.ProjectManage;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IProjectCalendarService
    {
        /// <summary>
        /// 获取工作时间
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<WorkTimeBo> getWorkTimesByProjectId(int id);
        /// <summary>
        /// 获取项目日历,根据项目编号获取项目日历
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        ProjectCalendarBo getProjectCalendarByProjectId(int id);
        /// <summary>
        /// 保存项目日历,根据项目编号保存项目日历
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool saveProjectCalendarByProjectId(ProjectCalendarBo projectcalendar,int id);
        /// <summary>
        /// 保存全设置项目日历,根据项目编号保存项目日历
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool saveAllProjectCalendarByProjectId(ProjectCalendarBo projectcalendar, int id);
        /// <summary>
        /// 把当前项目日历设置保存成默认设置
        /// </summary>
        /// <param name="projectcalendar"></param>
        /// <returns></returns>
        [OperationContract]
        bool setProjectCalendarToDefault(ProjectCalendarBo projectcalendar);
        /// <summary>
        /// 从读取日历默认配置
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        ProjectCalendarBo setProjectCalendarFromDefault();
    }
}
