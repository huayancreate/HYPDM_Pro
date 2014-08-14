using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.ProjectManage;
using PDM_Entity.MyTaskBox;
using System.Data;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class CreateNewProjectService : ICreateNewProjectService
    {
        public string ProductSave(Product product)
        {
            return "";
        }

        public string ProductModify(Product product)
        {
            return "";
        }

        public bool ProductRemove(int id)
        {
            return false;
        }

        public List<TreeNode> GetProjectRoles()
        {
            string sql = @"select r.id as ID, g.name as Gname, r.name as Name 
from `group` as g,role as r,group_role as gr 
where g.id = gr.group_id and r.id = gr.role_id and r.is_delete='0' and g.name = '项目角色'";
            DataTable dt = HYUtils.MySqlUtil.Query(sql);
            List<TreeNode> roles = new List<TreeNode>();
            roles.Add(new TreeNode() { ID = 0, Name = "项目角色" });
            foreach (DataRow dr in dt.Rows)
            {
                roles.Add(new TreeNode() { ID = Convert.ToInt32(dr["ID"]), Name = dr["Name"].ToString(), ParentID = 0 });
            }
            return roles;
        }

        public List<TreeNode> GetEmpoyeesByRoleID(int roleid)
        {
            int i = 0;
            List<TreeNode> employees = new List<TreeNode>();
            string sql = @"SELECT ID,Name FROM DEPARTMENT WHERE IS_DELETE='0'";
            DataTable dep = HYUtils.MySqlUtil.Query(sql);
            foreach (DataRow dr in dep.Rows)
            {
                employees.Add(new TreeNode() { ID = i = Convert.ToInt32(dr["ID"]), Name = dr["Name"].ToString()});

            }
            sql = @"select d.id as pid,u.id as id, d.name as department, u.real_name as name 
from department as d,users as u, users_department as ud, users_role ur 
where d.id = ud.department_id and u.id = ud.users_id and u.id = ur.users_id and u.is_delete='0' and ur.role_id ='" + roleid + "'";
            DataTable emp = HYUtils.MySqlUtil.Query(sql);
            foreach (DataRow dr in emp.Rows)
            {
                i ++;
                employees.Add(new TreeNode() { ID = i, Name = dr["name"].ToString(), ParentID = Convert.ToInt32(dr["pid"]), Column_1 = dr["id"].ToString() });
            }
            return employees;
        }
    }
}
