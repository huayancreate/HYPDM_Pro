using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 任务类型
    /// </summary>
    public class TaskTypebo
    {
        public int ID { get; set; }//任务类型编号
        public string Name { get; set; }//任务类型名称
        public int ParentID { get; set; }//任务父类型编号
    }
}
