using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ChangeManagement
{
    /// <summary>
    /// 变更申请书
    /// </summary>
    public class ChangeApplicatioin
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Version { get; set; }
        public string EffectTime { get; set; }
        public string State { get; set; }
        public string SecurityLevel { get; set; }
        public string Creator { get; set; }
        public string Remark { get; set; }
    }
}
