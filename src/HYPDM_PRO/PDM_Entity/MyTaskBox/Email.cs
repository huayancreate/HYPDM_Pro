using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    public class Email
    {
        public int ID { get; set; }//邮件编号
        public string Topic { get; set; }//邮件主体
        public string Sender { get; set; }//发送人
        public string Saddress { get; set; }//发送人地址
        public string Recipients { get; set; }//收送人
        public string Raddress { get; set; }//收件人地址
        public string Body { get; set; }//收送人
        public string Signed { get; set; }//是否读取
        public string SendTime { get; set; }//发送时间
        public string Size { get; set; }//邮件大小
        public string Attachment { get; set; }//邮件大小
    }
}
