using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;
using System.ComponentModel;


namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
     public  class UsersManage : IUsersManage
    {
        public bool AddUser(Users user)
        {
            return false;
        }
        public bool DeleteUser(int id)
        {
            return false;
        }
        public bool ModifyUser(Users user)
        {
            return false;
        }
        public IList<Users> FindUser(String condition)
        {
            IList<Users> list = new BindingList<Users>();
            Users user  = new Users();
            Users user1 = new Users();
            Users user2 = new Users();
            Users user3 = new Users();

            user.login_name = "小徐";
            user.real_name = "查到了";
            user.isChecked = false;
            user.birthday = new DateTime();
            user.sex = "男";
            user.age = 18;
            user.remark = "我是小徐,大家好";
            user.major = "本科（买的）";
            user.email = "119@.com";
            user.birthday = new DateTime();
            user.company_id = 1;
            user.audit_state = "0";
            user.stor_key = "123";
            user.mobile_phone = "119";
            user.office_phone = "120";
            user.immediate_manager = "威哥";
            user.user_number = "1234567usernumber";
            user.default_department = "酱油部门";
            user.create_user_id = 123;
            user.create_date = new DateTime();
            user.modify_user_id = 1234;
            user.modify_date = new DateTime();
            user.is_delete = "1";


            user1.login_name = "小宫";
            user1.real_name = "很高兴";
            user1.isChecked = false;
            user1.birthday = new DateTime();
            user1.sex = "男";
            user1.age = 18;
            user1.remark = "我是小宫,大家好";
            user1.major = "专科";
            user1.email = "119@.com";
            user1.birthday = new DateTime();
            user1.company_id = 1;
            user1.audit_state = "0";
            user1.stor_key = "123";
            user1.mobile_phone = "119";
            user1.office_phone = "120";
            user1.immediate_manager = "威哥";
            user1.user_number = "123456usernumber";
            user1.default_department = "酱油部门";
            user1.create_user_id = 123;
            user1.create_date = new DateTime();
            user1.modify_user_id = 1234;
            user1.modify_date = new DateTime();
            user1.is_delete = "1";

            
            
            
            user2.login_name = "威哥";
            user2.real_name = "很吊啊";
            user2.isChecked = false;
            user2.birthday = new DateTime();
            user2.sex = "男";
            user2.age = 18;
            user2.remark = "我是威哥,大家好";
            user2.major = "本科";
            user2.email = "119@.com";
            user2.birthday = new DateTime();
            user2.user_number = "1234usernumber";
            user2.company_id = 1;
            user2.audit_state = "0";
            user2.stor_key = "123";
            user2.mobile_phone = "119";
            user2.office_phone = "120";
            user2.immediate_manager = "老臣";
            user2.default_department = "研发部";
            user2.create_user_id = 123;
            user2.create_date = new DateTime();
            user2.modify_user_id = 1234;
            user2.modify_date = new DateTime();
            user2.is_delete = "1";

            user3.login_name = "总监";
            user3.real_name = "不满意";
            user3.isChecked = false;
            user3.birthday = new DateTime();
            user3.user_number = "1123456";
            user3.sex = "男";
            user.age = 18;
            user3.remark = "我是总监,大家好";
            user3.major = "本科";
            user3.email = "119@.com";
            user3.birthday = new DateTime();
            user3.company_id = 1;
            user3.audit_state = "0";
            user3.stor_key = "123";
            user3.mobile_phone = "119";
            user3.office_phone = "120";
            user3.immediate_manager = "主席";
            user3.default_department = "设计部";
            user3.create_user_id = 123;
            user3.create_date = new DateTime();
            user3.modify_user_id = 1234;
            user3.modify_date = new DateTime();
            user3.is_delete = "1";

            list.Add(user);
            list.Add(user1);
            list.Add(user2);
            list.Add(user3);

            return list;
        }
        public Role FindRole(int id) 
        {
            Role role = new Role();
            role.name = "系统管理员";
            return role; 
        }
    }
}
