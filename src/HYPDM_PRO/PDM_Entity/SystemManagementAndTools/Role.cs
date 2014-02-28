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
        public int id { get; set;}
        [DataMember(Order = 2)]
        public String name { get; set;}

    }
}
