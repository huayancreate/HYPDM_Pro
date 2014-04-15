using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class SerialNumber
    {
        [DataMember(Order=1)]
        public int id { get; set; }
        
        [DataMember(Order=2)]
        public int code_scheme_id { get; set; }
        
        [DataMember(Order=3)]
        public String table_name { get; set; }
        
        [DataMember(Order=4)]
        public int code_id { get; set; }

        [DataMember(Order=5)]
        public int create_user_id { get; set; }

        [DataMember(Order=6)]
        public DateTime create_date { get; set; }

        [DataMember(Order=7)]
        public int modify_user_id { get; set; }

        [DataMember(Order=8)]
        public DateTime modify_date { get; set; }

        [DataMember(Order=9)]
        public String is_delete { get; set; }


    }
}
