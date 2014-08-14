using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    public class ProjectTask
    {
        public int ID { get; set; }
        public string BelongProduct { get; set; }
        public string BelongTask { get; set; }
        public string TaskName { get; set; }
        public string Creator { get; set; }
        public string Executor { get; set; }
        public string State { get; set; }
    }
}
