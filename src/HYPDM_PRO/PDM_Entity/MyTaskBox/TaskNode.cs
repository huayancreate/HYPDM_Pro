using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskNode
    {
        public int Sequence { get; set; }//序号
        public string Name { get; set; }//名称
        public string State { get; set; }//状态
        public string AuditNumber { get; set; }//审核人数
    }
}
