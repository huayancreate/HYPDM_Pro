using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.SystemManagementAndTools
{
    [DataContract]
    public class Users
    {
         [DataMember(Order = 1)]
         public int id { get; set; }
         [DataMember(Order = 2)]
         public String login_name { get; set; }

         [DataMember(Order = 3)]
         public String real_name { get; set; }
         [DataMember(Order = 4)]
         public String password { get; set; }
         [DataMember(Order = 5)]
         public String sex { get; set; }
         [DataMember(Order = 6)]
         public int age { get; set; }
         [DataMember(Order = 7)]
         public String remark { get; set; }
         [DataMember(Order = 8)]
         public String major { get; set; }
         [DataMember(Order = 9)]
         public String email { get; set; }
         [DataMember(Order = 10)]
         public DateTime birthday { get; set; }
         [DataMember(Order = 11)]
         public String duty { get; set; }
         [DataMember(Order = 12)]
         public String id_card { get; set; }
         [DataMember(Order = 13)]
         public String address { get; set; }
         [DataMember(Order = 14)]
         public String state { get; set; }
         [DataMember(Order = 15)]
         public DateTime login_time { get; set; }
         [DataMember(Order = 16)]
         public DateTime logout_time { get; set; }
         [DataMember(Order = 17)]
         public int company_id { get; set; }
         [DataMember(Order = 18)]
         public String audit_state { get; set; }
         [DataMember(Order = 19)]
         public String stor_key { get; set; }
         [DataMember(Order = 20)]
         public String mobile_phone { get; set; }
         [DataMember(Order = 21)]
         public String office_phone { get; set; }
         [DataMember(Order = 22)]
         public String user_number { get; set; }
         [DataMember(Order = 23)]
         public String immediate_manager { get; set; }
         [DataMember(Order = 24)]
         public String default_department { get; set; }
         [DataMember(Order = 25)]
         public int create_user_id;
         [DataMember(Order = 26)]
         public DateTime create_date { get; set; }
         [DataMember(Order = 27)]
         public int modify_user_id { get; set; }
         [DataMember(Order = 28)]
         public DateTime modify_date { get; set; }
         [DataMember(Order = 29)]
         public String is_delete { get; set; }
          [DataMember(Order = 30)]
         public bool isChecked { get; set; }
        
    }
}
