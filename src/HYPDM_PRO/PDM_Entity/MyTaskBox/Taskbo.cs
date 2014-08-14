using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    public class Taskbo
    {
        public int ID { get; set; }//编号
        public string Name { get; set; }//名称
        public string State { get; set; }//状态
        public int Percent { get; set; }//百分比
        public string BelongTask { get; set; }//所属任务
        public string BelongProject { get; set; }//所属项目
        public string BelongProduct { get; set; }//所属产品
        public string Creator { get; set; }//创建人
        public string Executor { get; set; }//执行人
        public string PlanStartTime { get; set; }//计划开始时间
        public string PlanEndTime { get; set; }//计划结束时间
        public string EarliestStartTime { get; set; }//最早开始时间
        public string LatereEinddatum { get; set; }//最晚完成时间
        public string StartTime { get; set; }//实际开始时间
        public string EndTime { get; set; }//实际结束时间
        public string WarningPercentage { get; set; }//预警百分比
        public string WarningTime { get; set; }//预警时间
        public string WhetherItCanDecompose { get; set; }//是否能费解
        public string Description { get; set; }//描述
        public string Remark { get; set; }//备注
    }
}
