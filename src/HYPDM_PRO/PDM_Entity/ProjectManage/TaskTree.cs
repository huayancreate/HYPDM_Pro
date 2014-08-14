using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 任务树
    /// </summary>
    public class TaskTree
    {
        /// <summary>
        /// 设置或获取任务编号
        /// </summary>
        public int ID { get; set; }
        public int ParentID { get; set; }
        /// <summary>
        /// 获取设置任务类型.项目:J/产品:D/活动:C/任务:T/审核:A
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 设置或获取任务名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 设置或获取父类名称
        /// </summary>
        public string ParentName { get; set; }
        /// <summary>
        /// 设置或获取任务状态
        /// </summary>
        public string State { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
