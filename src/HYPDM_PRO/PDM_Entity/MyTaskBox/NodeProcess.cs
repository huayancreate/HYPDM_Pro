using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    public class NodeProcess
    {
        public string Auditor { get; set; }//审核人
        public string AuditState { get; set; }//审核状态
        public string StartTime { get; set; }//开始时间
        public string EndTime { get; set; }//结束时间
    }
}
