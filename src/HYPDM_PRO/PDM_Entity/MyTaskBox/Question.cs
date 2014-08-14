using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 问提类
    /// </summary>
    public class Question
    {
        public int ID { get; set; }//编号
        public string Title { get; set; }//标题
        public string Body { get; set; }//为题内容
        public string Creator { get; set; }//创建人
        public string Sign { get; set; }//是否读取
        public string Email { get; set; }//邮件地址
        public string CreateTime { get; set; }//创建时间
        public List<Reply> replies { get; set; }//回复列表
    }
}
