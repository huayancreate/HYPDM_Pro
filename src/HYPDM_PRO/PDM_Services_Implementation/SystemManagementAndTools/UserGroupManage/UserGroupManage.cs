using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;
using PDM_Services_Interface;
using System.ComponentModel;



namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class UserGroupManage : IUserGroupManage
    {
        public IList<Group> findGroup(String condition)
        {
            IList<Group> list = new BindingList<Group>();
            Group g = new Group();
            g.Name = "调研组";
            g.Id = 1;
            g.Create_user_id = 12345;
            g.Create_date = new DateTime();
            g.Modify_user_id = 1234566;
            g.Modify_date = new DateTime();
            g.Remark = "我们是负责市场调研的，我们很有价值";

            Group g1 = new Group();
            g1.Name = "研发组";
            g1.Id = 2;
            g1.Create_user_id = 12345;
            g1.Create_date = new DateTime();
            g1.Modify_user_id = 1234566;
            g1.Modify_date = new DateTime();
            g1.Remark = "我们是负责项目研发的，我们很有价值";

            Group g2 = new Group();
            g2.Name = "酱油组";
            g2.Id = 3;
            g2.Create_user_id = 12345;
            g2.Create_date = new DateTime();
            g2.Modify_user_id = 1234566;
            g2.Modify_date = new DateTime();
            g2.Remark = "we are busy working everday, we are busy doing with trifles,"+
            "we are the most humble yards farmers";
            
            list.Add(g);
            list.Add(g1);
            list.Add(g2);
            return list;

        }
        public bool AddGroup(Group group)
        {
            return false;
        }
        public bool DeleteGroup(int groupID)
        {
            return false;
        }

        public IList<Role> findRelatedRoles(int groupID) 
        {
            IList<Role> list = new List<Role>();
            Role role1 = new Role();
            role1.name = "系统管理员";
            Role role2 = new Role();
            role2.name = "文档管理员";
            Role role3 = new Role();
            role3.name = "图纸管理员";
            list.Add(role1);
            list.Add(role2);
            list.Add(role3);
            return list;

         }
        public IList<Users> findRelatedUsers(int groupID)
        {
            IList<Users> list = new List<Users>();
            Users user1 = new Users();
            user1.login_name = "用户甲";
            Users user2 = new Users();
            user2.login_name = "用户乙";
            Users user3 = new Users();
            user3.login_name = "用户丙";

            list.Add(user1);
            list.Add(user2);
            list.Add(user3);

            return list;
       }
    }
}
