using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 树节点
    /// </summary>
    public class TreeNode
    {
        public int ID { get; set; }//编号
        public int ParentID { get; set; }//父节点编号
        public string Name { get; set; }//节点名称
        public string Column_1 { get; set; }//
    }
}
