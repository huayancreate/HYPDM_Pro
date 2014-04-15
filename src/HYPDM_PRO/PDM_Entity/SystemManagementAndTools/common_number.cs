using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class common_number
    {
        [DataMember(Order=1)]
        public int id { get; set; }
        [DataMember(Order = 2)]
        public String group_name { get; set; }
        [DataMember(Order = 3)]
        public String value { get; set; }
        [DataMember(Order = 4)]
        public int parent_id { get; set; }
        [DataMember(Order = 5)]
        public String remark { get; set; }
        [DataMember(Order = 6)]
        public int digit { get; set; }
        [DataMember(Order = 7)]
        public bool is_group { get; set; }
        [DataMember(Order = 8)]
        public int create_user_id { get; set; }
        [DataMember(Order = 9)]
        public DateTime create_date { get; set; }
        [DataMember(Order = 10)]
        public int modify_user_id   { get; set; }
        [DataMember(Order = 11)]
        public DateTime modify_date { get; set; }
        [DataMember(Order = 12)]
        public String is_delete { get; set; } 
   }
}
