using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    public class CheckSignTask
    {
        public int ID { get; set; }//审签任务编号
        public string NodeName { get; set; }//节点名称
        public string DocumentCode { get; set; }//文档编号
        public string DocumentVersion { get; set; }//文档版本
        public string DocumentName { get; set; }//文档名称
        public string Submitter { get; set; }//提交人
        public string State { get; set; }//状态
        public string Type { get; set; }//类型
        public string BelongTask { get; set; }//所属任务
        public string BelongProduct { get; set; }//所属产品
    }
}
