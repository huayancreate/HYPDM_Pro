using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    public class ProjectGroupUser
    {
        public int Id { get; set; }//用户编号
        public string Name { get; set; }//名称
        public string Activity { get; set; }//所属活动
        public string Role { get; set; }//所属角色
    }
}
