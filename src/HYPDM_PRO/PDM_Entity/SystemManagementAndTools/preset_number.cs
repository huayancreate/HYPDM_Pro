using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class preset_number
    {
        [DataMember(Order= 1)]
        public int id { get; set; }
        [DataMember(Order =2)]
        public String remark { get; set; }
        [DataMember(Order =3)]
        public String value { get; set; }
        [DataMember(Order =4)]
        public int create_user_id {get;set;}
        [DataMember(Order =5)]
        public DateTime create_date { get; set; }
        [DataMember(Order =6)]
        public int modify_user_id { get; set; }
        [DataMember(Order =7)]
        public DateTime modify_date { get; set; }
        [DataMember(Order = 8)]
        public String is_delete { get; set; }

    }
}
