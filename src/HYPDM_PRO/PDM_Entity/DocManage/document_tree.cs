using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{

    [DataContract]
    public class document_tree
    {
        [DataMember(Order = 1)]
        public int id { get; set; }

        [DataMember(Order = 2)]
        public string name { get; set; }

        [DataMember(Order = 3)]
        public int parent_id { get; set; }

        [DataMember(Order = 3)]
        public String parent_name { get; set; }

        [DataMember(Order = 3)]
        public String all_name { get; set; }

        [DataMember(Order = 4)]
        public string is_leaf { get; set; }

        [DataMember(Order = 5)]
        public List<document> DocumentList { get; set; }

        [DataMember(Order = 5)]
        public List<document_tree> subDocType { get; set; }
    }
}
