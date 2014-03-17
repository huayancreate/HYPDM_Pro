using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class Role
    {
        [DataMember(Order = 1)]
        public int Id { get; set;}
        [DataMember(Order = 2)]
        public String name { get; set;}
        [DataMember(Order = 3)]
        public bool isChecked { get; set;}
        [DataMember(Order = 4)]
        public String coding { get; set; }
        [DataMember(Order = 5)]
        public String Remark { get; set; }

    }
}
