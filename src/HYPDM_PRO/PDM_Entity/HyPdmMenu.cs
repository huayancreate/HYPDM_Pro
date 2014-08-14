using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity
{
    public class HyPdmMenu
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Assembly { get; set; }
        public string ViewName { get; set; }
    }
}
