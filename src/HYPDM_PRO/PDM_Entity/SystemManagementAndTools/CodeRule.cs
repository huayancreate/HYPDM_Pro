using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class CodeRule
    {
        [DataMember(Order = 1)]
        public int id { get; set; }
        [DataMember(Order = 2)]
        public int code_scheme_id { get; set; }
        [DataMember(Order = 3)]
        public String name { get; set; }
        [DataMember(Order = 4)]
        public String remark { get; set; }
        [DataMember(Order = 5)]
        public int type { get; set; }
        [DataMember(Order = 6)]
        public int create_user_id { get; set; }
        [DataMember(Order = 7)]
        public DateTime create_date { get; set; }
        [DataMember(Order = 8)]
        public int modify_user_id { get; set; }
        [DataMember(Order = 9)]
        public DateTime modify_date { get; set; }
        [DataMember(Order = 10)]
        public String is_delete { get; set; }
        [DataMember(Order = 11)]
        public String sort_key { get; set; }

    }
}
