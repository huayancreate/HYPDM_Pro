using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class CodeRuleCodes
    {
        [DataMember(Order = 1)]
        public String name { get; set; }
        [DataMember(Order = 2)]
        public String remark { get; set; }
        [DataMember(Order = 3)]
        public int type { get; set; }
        [DataMember(Order = 4)]
        public int digit { get; set; }
        [DataMember(Order = 5)]
        public String typeToString { get; set; }
        [DataMember(Order = 6)]
        public int id { get; set; }
        [DataMember(Order = 7)]
        public int codeSchemeId { get; set; }

        
    }
}
