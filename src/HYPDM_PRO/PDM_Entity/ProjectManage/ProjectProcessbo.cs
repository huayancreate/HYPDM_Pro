using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    public class ProjectProcessbo
    {
        public int Id { get; set; }//流程编号
        public string Name { get; set; }//流程名称
        public string Version { get; set; }//流程版本
        public string Creator { get; set; }//创建时间
        public string CreateTime { get; set; }//创建时间
        public string State { get; set; }//流程状态,有效/无效
    }
}
