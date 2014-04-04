using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class MaterialType
    {
        [DataMember(Order = 1)]
        public int id {get;set;}

        [DataMember(Order = 2)]
        public string name{get;set;}

        [DataMember(Order = 3)]
        public string remark{get;set;}

        [DataMember(Order = 4)]
        public string is_last{get;set;}

        [DataMember(Order = 5)]
        public string child_mark_length{get;set;}

        [DataMember(Order = 6)]
        public string code_start{get;set;}

        [DataMember(Order = 7)]
        public string code_length{get;set;}

        [DataMember(Order = 8)]
        public int parent_id{get;set;}

        [DataMember(Order = 9)]
        public int create_user_id{get;set;}

        [DataMember(Order = 10)]
        public DateTime create_date{get;set;}

        [DataMember(Order = 11)]
        public int modify_user_id{get;set;}

        [DataMember(Order = 12)]
        public DateTime modify_date{get;set;}

        [DataMember(Order = 13)]
        public string is_delete{get;set;}
    }
}
