using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 使用者
    /// </summary>
    public class PersonBo
    {
        public int Id { get; set; }//编号
        public string LoginName { get; set; }//登录名称
        public string Name { get; set; }//真是姓名
        public string Sex { get; set; }//性别
        public string Remark { get; set; }//备注
        public string Major { get; set; }//专业
        public string Email { get; set; }//电子邮箱
        public string Birthday { get; set; }//生日
        public string Duty { get; set; }//职务
        public string IdCard { get; set; }//身份证号码
        public string Address { get; set; }//地址
        public string State { get; set; }//
        public string SompanyName { get; set; }//所在公司名称
        public string MobilePhone { get; set; }//移动电话
        public string OfficePhone { get; set; }//办公电话
    }
}
