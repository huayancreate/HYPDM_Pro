using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class User
    {
        public int ID { get; set; }//编号
        public string Name { get; set; }//姓名
        public string Gender { get; set; }//性别
        public string Specialty { get; set; }//专业
        public string Birthday { get; set; }//生日
        public string Duty { get; set; }//职务
        public string Office { get; set; }//办公室
        public string Workspace { get; set; }//工作空间
        public string Phone { get; set; }//电话
        public string Email { get; set; }//电子邮件
        public string Stamp { get; set; }//电子印章
        public string Remark { get; set; }//备注
    }
}
