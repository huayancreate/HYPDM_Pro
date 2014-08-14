using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 我的任务,任务树
    /// </summary>
    public class MyTaskTree
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
    }
}
