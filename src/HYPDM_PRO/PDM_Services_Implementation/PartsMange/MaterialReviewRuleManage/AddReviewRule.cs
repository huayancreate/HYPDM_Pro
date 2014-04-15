using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class AddReviewRule : IAddReviewRule
    {
        public string Save(int id) 
        {
            
            return "";

        }

        public bool DeleteReviewProperty(int id) 
        {
            RepeatRule r = new RepeatRule();
            r.create_date = new DateTime();
            r.create_user_id = 001;
            r.end_time = new DateTime();
            r.id = 001;
            r.is_delete = "是";
            r.is_strict = "否";
            r.modify_date = new DateTime();
            r.modify_user_id = 001;
            r.name = "端午";
            r.remark = "中国传统节日";
            r.start_time = new DateTime();

            RepeatRule r1 = new RepeatRule();
            r1.create_date = new DateTime();
            r1.create_user_id = 002;
            r1.end_time = new DateTime();
            r1.id = 002;
            r1.is_delete = "否";
            r1.is_strict = "否";
            r1.modify_date = new DateTime();
            r1.modify_user_id = 002;
            r1.name = "中秋";
            r1.remark = "中国传统节日";
            r1.start_time = new DateTime();
                 
            return false;  
        }
    }
}
