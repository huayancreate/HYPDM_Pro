using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    public class ProjectBo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public string State { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
