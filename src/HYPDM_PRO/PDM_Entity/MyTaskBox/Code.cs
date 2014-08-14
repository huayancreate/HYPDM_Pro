using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 编码属性类
    /// </summary>
    public class Code
    {
        public int ID { get; set; }//编号
        public string Coding { get; set; }//编码
        public string Name { get; set; }//名称
        public string Applicant { get; set; }//申请人
        public string ApplicationTime { get; set; }//申请时间
        public string State { get; set; }//状态
        public string CodingScheme { get; set; }//编码方案
    }
}
