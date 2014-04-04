using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class Unit
    {
        [DataMember(Order = 1)]
        public int id{set;get;}

        [DataMember(Order = 2)]
        public string number{set;get;}
        
        [DataMember(Order = 3)]
        public string name{set;get;}

        [DataMember(Order = 4)]
        public string scale{set;get;}

        [DataMember(Order = 5)]
        public string is_default{set;get;}

        [DataMember(Order = 6)]
        public int unit_group_id{set;get;}

        [DataMember(Order = 7)]
        public int create_user_id{set;get;}

        [DataMember(Order = 8)]
        public DateTime create_date{set;get;}

        [DataMember(Order = 9)]
        public int modify_user_id{set;get;}

        [DataMember(Order = 10)]
        public DateTime modify_date{set;get;}

        [DataMember(Order = 11)]
        public string is_delete{set;get;}
       
    }
}
