using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Services_Interface;
using PDM_Entity.SystemManagementAndTools;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace PDM_Services_Implementation
{
     [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class RoleManage :IRoleManage
    {
         public bool AddRole(Role role)
         {
             return false;
         }
         public IList<Role> findRole(String condition)
         {
             IList<Role> list = new BindingList<Role>();
             Role role = new Role();
             role.name = "系统管理员";
             role.isChecked = false;
             role.coding = "100";
             role.Id = 1;
             role.Remark = "我是系统管理员";
             Role role1 = new Role();
             role1.isChecked = false;
             role1.name = "工艺管理员";
             role1.coding = "100";
             role1.Id = 2;
             role1.Remark = "我是工艺管理员";
             Role role2 = new Role();
             role2.name = "产品设计人员";
             role2.isChecked = false;
             role2.coding = "100";
             role2.Id = 3;
             role2.Remark = "我是产品设计人员";
             Role role3 = new Role();
             role3.Remark = "";
             role3.Id = 4;
             role3.name = "产品设计人员";
             role3.isChecked = false;
             role3.coding = "100";
             role3.Remark = "我是产品设计人员";
             
             
             list.Add(role);
             list.Add(role1);
             list.Add(role2);
             list.Add(role3);
             
             return list;
         }
        public  bool DeleteRole(int roleId) 
        {
             return false;
        }
        public List<Users> findRelatedUser(int roleId)
        {
            List<Users> list = new List<Users>();
            Users user = new Users();
            user.login_name = "小徐";
            user.id = 2;
            Users user1 = new Users();
            user1.login_name= "小宫";
            user1.id = 3;
            list.Add(user);
            list.Add(user1);

            return list;
        }
        public List<Group> findRelatedGroup(int roleId)
        {
            List<Group> list = new List<Group>();
            Group group = new Group();
            group.Name = "研发组";
            group.Id = 1;
            Group group1 = new Group();
            group1.Id = 2;
            group1.Name = "酱油组";
            list.Add(group);
            list.Add(group1);

            return list;
        }
       public IList<Operation> findRelatedOperation(int roleId) 
        {
            IList<Operation> list = new BindingList<Operation>();
            Operation operation = new Operation();
            operation.Id = 1;
            operation.Name = "删除";
            Operation operation1 = new Operation();
            operation1.Id = 1;
            operation1.Name = "添加";
            list.Add(operation);
            list.Add(operation1);
            return list;
        }
        public IList<Menus> findRelatedMenu(int roleId) 
        {
            IList<Menus> list = new BindingList<Menus>();
            Menus menu = new Menus();
            menu.Id = 1;
            menu.Name = "系统管理工具";
            Menus menu1 = new Menus();
            menu1.Id = 2;
            menu1.Name = "项目管理";
            list.Add(menu);
            list.Add(menu1);
            return list;
        }
        
    }
}
