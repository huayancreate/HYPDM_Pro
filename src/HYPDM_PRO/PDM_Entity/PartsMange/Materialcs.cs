using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class Materialcs
    {
        [DataMember(Order = 1)]
        public int ID {get; set;}

        [DataMember(Order = 2)]
        public int unit_id {get; set;}

        [DataMember(Order = 3)]
        public string supplied_id { get; set;}

        [DataMember(Order = 4)]
        public string image {get; set;}

        [DataMember(Order = 5)]
        public string is_encode {get; set;}

        [DataMember(Order = 6)]
        public string status {get;set;}

        [DataMember(Order = 7)]
        public string is_enable {get; set;}

        [DataMember(Order = 8)]
        public int product_category_id {get; set;}

        [DataMember(Order = 9)]
        public int material_type_id {get; set;}

        [DataMember(Order = 10)]
        public int create_user_id {get; set;}

         [DataMember(Order = 11)]
        public DateTime create_date {get; set;}

         [DataMember(Order = 12)]
        public int modify_user_id {get; set;}

         [DataMember(Order = 13)]
        public DateTime modify_date {get; set;}

         [DataMember(Order = 14)]
        public string is_delete {get; set;}

         [DataMember(Order = 15)]
         public string name { get; set;}

         [DataMember(Order = 16)]
         public string versions {get; set;}

         [DataMember(Order = 17)]
         public String number {get; set;}

         [DataMember(Order = 18)]
         public string type {get; set;}

         [DataMember(Order = 19)]
         public string property {get; set;}

         [DataMember(Order = 20)]
         public int material_box_id {get; set;}


         public IList<Materialcs> Mate()
         {
             throw new NotImplementedException();
         }


         [DataMember(Order = 21)]
         public string cn_name { get; set;}

         [DataMember(Order = 22)]
         public string widgh { get; set; }
    }
}
