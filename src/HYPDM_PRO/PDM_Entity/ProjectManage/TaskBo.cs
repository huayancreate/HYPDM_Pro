using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    public class TaskBo
    {
        public int Id { get; set; }//任务编号
        public string Name { get; set; }//任务名称
        public string WhichProductName { get; set; }//所属项目名称
        public string WhichProductVersion { get; set; }//所属项目版本
        public string PlanStartTime { get; set; }//计划开始时间
        public string PlanEndTime { get; set; }//计划结束时间
        public string StartTime { get; set; }//开始时间
        public string EndTime { get; set; }//结束时间
        public string Type { get; set; }//任务类型
        public int Percent { get; set; }//任务进度
        public string State { get; set; }//任务状态
        public string Creator { get; set; }//创建人
        public string Executor { get; set; }//执行人
        public int ExecuteState { get; set; }//执行状态
        public int WarningPercent { get; set; }//预警百分比
        public string WaringTime { get; set; }//预警时间
        public string IsAnalysis { get; set; }//能否再分解
        public string ParentName { get; set; }//所属任务
    }
}
