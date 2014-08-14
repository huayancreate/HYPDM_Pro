using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    public class DesignTask
    {
        public int ID { get; set; }//审签任务编号
        public string Name { get; set; }//节点名称
        public string Creator { get; set; }//创建人
        public string Executor { get; set; }//提交人
        public string State { get; set; }//状态
        public string Type { get; set; }//类型
        public string BelongTask { get; set; }//所属任务
    }
}
