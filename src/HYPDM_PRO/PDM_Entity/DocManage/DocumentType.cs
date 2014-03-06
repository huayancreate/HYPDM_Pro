using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity
{
    [DataContract]
    public class DocumentType
    {
        [DataMember(Order = 1)]
        public int id { get; set; }

        [DataMember(Order = 2)]
        public string name { get; set; }

        [DataMember(Order = 3)]
        public String parent_id { get; set; }

        [DataMember(Order = 4)]
        public string is_leaf { get; set; }

    }
}
