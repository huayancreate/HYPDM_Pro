using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 文档包信息
    /// </summary>
    public class DocumentPackage
    {
        public int Id { get; set; }//文档包编号
        public int ProcessId { get; set; }//流程编号
        public string Name { get; set; }//名称
        public string Type { get; set; }//类型
    }
}
