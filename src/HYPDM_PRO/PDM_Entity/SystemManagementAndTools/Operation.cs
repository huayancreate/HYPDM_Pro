using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class Operation
    {
        [DataMember]
        public int Id  { get;  set;}
        [DataMember]
        public String Name{ get;  set;}
    }
}
