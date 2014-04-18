using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class UnitGroup
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public string number { get; set; }

        [DataMember(Order = 3)]
        public string name { get; set; }

        [DataMember(Order = 4)]
        public string description { get; set; }

        [DataMember]
        public int Parent_Id { get; set; }

        [DataMember(Order = 5)]
        public int create_user_id { get; set; }

        [DataMember(Order = 6)]
        public DateTime create_date { get; set; }

        [DataMember(Order = 7)]
        public int modify_user_id { get; set; }

        [DataMember(Order = 8)]
        public DateTime modify_date { get; set; }

        [DataMember(Order = 9)]
        public string is_delete { get; set; }
    }
}
