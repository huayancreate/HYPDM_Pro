using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    public class ChangeNotification
    {
        public int ID { get; set; }//编号
        public string Code { get; set; }//编码
        public string Version { get; set; }//版本
        public string Name { get; set; }//名称
        public string Sendor { get; set; }//发送人
        public string SendTime { get; set; }//发送时间
    }
}
