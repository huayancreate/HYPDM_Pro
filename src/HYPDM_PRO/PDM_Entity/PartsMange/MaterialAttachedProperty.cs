using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public  class MaterialAttachedProperty
    {
        [DataMember(Order = 1)]
        public int id{get;set;}

        [DataMember(Order = 2)]
        public string  cn_name{get;set;}

        [DataMember(Order = 3)]
        public string en_name{get;set;}

        [DataMember(Order = 4)]
        public string data_type{get;set;}
 
        [DataMember(Order = 5)]
        public string data_length{get;set;}

        [DataMember(Order = 6)]
        public string input_type{get;set;}

        [DataMember(Order = 7)]
        public string required{get;set;}

        [DataMember(Order = 8)]
        public string  default_value{get;set;} 

        [DataMember(Order = 9)]
        public string is_extends{get; set;}

        [DataMember(Order = 10)]
        public string is_query{get; set;}

        [DataMember(Order = 11)]
        public string width{get; set;}

        [DataMember(Order = 12)]
        public string property_type{get; set;}

        [DataMember(Order = 13)]
        public int material_property_type_id{get; set;}

        [DataMember(Order = 14)]
        public int create_user_id{get; set;}

        [DataMember(Order = 15)]
        public DateTime create_date{get; set;}

        [DataMember(Order = 16)]
        public int modify_user_id{get; set;}

        [DataMember(Order = 17)]
        public DateTime modify_date{get; set;}

        [DataMember(Order = 18)]
        public string is_delete{get; set;}
        
    }
}
