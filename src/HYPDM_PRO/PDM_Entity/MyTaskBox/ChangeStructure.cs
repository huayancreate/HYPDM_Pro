using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 变更结构
    /// </summary>
    public class ChangeStructure
    {
        public int ID { get; set; }//编号
        public string Name { get; set; }//零件名称
        public string PartCode{ get; set; }//零件编码
        public string PartVersion { get; set; }//零件版本
        public string ParentCode { get; set; }//父项件号
        public string ParentVersion { get; set; }//父件版本
        public string OldPartCode { get; set; }//旧零件编码
        public string OldPartVersion { get; set; }//旧零件版本
    }
}
