using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using System.ComponentModel;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class MaterialReviewRuleManage : IMaterialReviewRuleManage
    {
        public IList<RepeatRule> rep() 
        {
            IList<RepeatRule> r = new BindingList<RepeatRule>();
            RepeatRule R = new RepeatRule();
            RepeatRule Ra = new RepeatRule();
            RepeatRule Rb = new RepeatRule();

            R.name = "李元霸";
            R.remark = "吊丝中的战斗机";
            R.is_strict = "否";
            R.create_date =new DateTime();
            R.create_user_id = 302090;
            R.end_time = new DateTime();
            R.id = 1;
            R.is_delete = "是";
            R.modify_date = new DateTime();
            R.modify_user_id = 12;
            R.start_time = new DateTime();
            
            Ra.name = "程咬金";
            Ra.remark = "二逼中的战斗机";
            Ra.is_strict = "是";
            Ra.create_date = new DateTime();
            Ra.create_user_id = 302879;
            Ra.end_time = new DateTime();
            Ra.id = 2;
            Ra.is_delete = "是";
            Ra.modify_date = new DateTime();
            Ra.modify_user_id = 15;
            Ra.start_time = new DateTime();

            Rb.name = "宇文成都";
            Rb.remark = "战斗机中的战斗机";
            Rb.is_strict = "是";
            Rb.create_date = new DateTime();
            Rb.create_user_id = 302400;
            Rb.end_time = new DateTime();
            Rb.id = 3;
            Rb.is_delete = "是";
            Rb.modify_date = new DateTime();
            Rb.modify_user_id = 18;
            Rb.start_time = new DateTime();

            r.Add(R);
            r.Add(Ra);
            r.Add(Rb);
            return r;
        }

        public bool AddMaterialReviewRule(int id) 
        {
            return true;
        }

        public bool ModifyMaterialReviewRule(int id) 
        {
            return true;
        }

        public IList<RepeatRule> LookOverMaterialReviewRule(int id) 
        {
            IList<RepeatRule> MR = new BindingList<RepeatRule>();
            RepeatRule ra = new RepeatRule();
            RepeatRule rb = new RepeatRule();
            RepeatRule rc = new RepeatRule();

            ra.name = "裴元庆";
            ra.remark = "拿手活：金光泻地";
            ra.is_strict = "是";
            ra.create_date = new DateTime();
            ra.create_user_id = 001;
            ra.end_time = new DateTime();
            ra.id = 01;
            ra.is_delete = "否";
            ra.modify_date = new DateTime();
            ra.modify_user_id = 10001;
            ra.start_time = new DateTime();

            rb.name = "罗成";
            rb.remark = "拿手活：千军斩将";
            rb.is_strict = "否";
            rb.create_date = new DateTime();
            rb.create_user_id = 002;
            rb.end_time = new DateTime();
            rb.id = 02;
            rb.is_delete = "否";
            rb.modify_date = new DateTime();
            rb.modify_user_id = 10002;
            rb.start_time = new DateTime();

            rc.name = "李靖";
            rc.remark = "拿手活：杀手锏";
            rc.is_strict = "否";
            rc.create_date = new DateTime();
            rc.create_user_id = 003;
            rc.end_time = new DateTime();
            rc.id = 03;
            rc.is_delete = "否";
            rc.modify_date = new DateTime();
            rc.modify_user_id = 10003;
            rc.start_time = new DateTime();

            return MR;
        }

        public bool DeleteMaterialReviewRule(int id) 
        {
            return true;  
        }

        public IList<RepeatRule> QueryMaterialReviewRule(string name, string is_strict, string remark) 
        {
            IList<RepeatRule> R = new BindingList<RepeatRule>();
            RepeatRule r1 = new RepeatRule();
            RepeatRule r2 = new RepeatRule();

            r1.name = "小二";
            r1.is_strict = "否";
            r1.remark = "古代酒店、客栈服务员";
            r1.create_date = new DateTime();
            r1.create_user_id = 1023;
            r1.end_time = new DateTime();
            r1.id = 2;
            r1.is_delete = "是";
            r1.modify_date = new DateTime();
            r1.modify_user_id = 200089;
            r1.start_time = new DateTime();

            r2.name = "小三";
            r2.is_strict = "是";
            r2.remark = "全世界女人的公敌";
            r2.create_date = new DateTime();
            r2.create_user_id = 1045;
            r2.end_time = new DateTime();
            r2.id = 45;
            r2.is_delete = "是";
            r2.modify_date = new DateTime();
            r2.modify_user_id = 300046;
            r2.start_time = new DateTime();

            R.Add(r1);
            R.Add(r2);
            return R;
        }

        public string DuplicateChecking(int id) 
        {
            return "";
        }
    }
}
