using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{
    
    [DataContract]
    public class department
    {
        [DataMember(Order = 1)]
        public string name { get; set; }

        [DataMember(Order = 1)]
        public int id { get; set; }

        [DataMember(Order = 1)]
        public int parent_id { get; set; }

        [DataMember(Order = 1)]
        public string parent_name { get; set; }
    }
}
