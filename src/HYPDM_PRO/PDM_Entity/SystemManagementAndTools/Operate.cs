using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class Operate
    {
        [DataMember]
        public int Id { get;set;}
        [DataMember]
        public String name { get; set; }
        [DataMember]
        public int ParentID { get; set; }
    }
}
