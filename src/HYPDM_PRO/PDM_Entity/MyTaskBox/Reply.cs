using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 问题的回复类
    /// </summary>
    public class Reply
    {
        public int ID { get; set; }//编号
        public string Body { get; set; }//内容
        public string Creator { get; set; }//创建人
        public string Email { get; set; }//邮件
        public string CreateTime { get; set; }//创建时间
    }
}
