using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class Group
    {
        [DataMember(Order = 1)]
        public int Id { get;set;}

        [DataMember(Order = 2)]
        public String Name { get; set;}

        [DataMember(Order = 3)]
        public String Remark { get; set; }

        [DataMember(Order = 4)]
        public int Create_user_id { get; set; }

        [DataMember(Order = 5)]
        public DateTime Create_date { get; set; }

        [DataMember(Order = 6)]
        public int Modify_user_id { get; set; }
        
        [DataMember(Order = 7)]
        public DateTime Modify_date {get; set;}
    }
}
