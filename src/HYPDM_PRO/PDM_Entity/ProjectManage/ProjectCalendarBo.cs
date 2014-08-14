using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PDM_Entity.ProjectManage
{
    public class ProjectCalendarBo
    {
        /// <summary>
        /// 项目日历业务
        /// </summary>
        public int Id { get; set; }//项目日历编号
        public string ProjectName { get; set; }//项目名称
        public string StartTime { get; set; }//项目计划开始时间
        public WeekBo Week { get; set; }//一周上班时间
        public List<WorkTimeBo> TimeSlot { get; set; }//工作时间端
        public List<WorkDateBo> DateState { get; set; }//被修改的日期和状态的json
    }
}
