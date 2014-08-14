using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 公告业务类
    /// </summary>
    public class Bulletin
    {
        public int ID { get; set; }//编号
        public string Title { get; set; }//标题
        public string Body { get; set; }//内容
        public string Sign { get; set; }//是否阅读
        public string Department { get; set; }//部门
        public string PublishTime { get; set; }//发布时间
    }
}
