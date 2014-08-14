using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    public class WorkDateBo
    {
        public WorkDateBo() { }
        public WorkDateBo(string date, string state)
        {
            Time = date;
            State = state;
        }
        public string Time { get; set; }
        public string State { get; set; }
    }
}
