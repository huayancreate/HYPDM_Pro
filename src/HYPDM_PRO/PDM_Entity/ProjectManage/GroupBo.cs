using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    public class GroupBo
    {
        public GroupBo() { }
        public GroupBo(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public GroupBo(int id, string name, string pName)
        {
            Id = id;
            Name = name;
            ParentName = pName;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
    }
}
