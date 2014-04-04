using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public  class RepeatRule
    {
        [DataMember(Order = 1)]
        public int id{get;set;}

        [DataMember(Order = 2)]
        public string name{get;set;}

        [DataMember(Order = 3)]
        public string remark{get;set;}

        [DataMember(Order = 4)]
        public string is_strict{get; set;}

        [DataMember(Order = 5)]
        public DateTime start_time{get; set;}

        [DataMember(Order = 6)]
        public DateTime end_time{get; set;}

        [DataMember(Order = 7)]
        public int create_user_id{get; set;}

        [DataMember(Order = 8)]
        public DateTime create_date{get;set;}

        [DataMember(Order = 9)]
        public int modify_user_id{get;set;}

        [DataMember(Order = 10)]
        public DateTime modify_date{get;set;}

        [DataMember(Order = 11)]
        public string is_delete{get; set;}
    }
}
