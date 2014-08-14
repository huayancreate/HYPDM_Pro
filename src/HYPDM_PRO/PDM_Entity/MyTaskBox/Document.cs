using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.MyTaskBox
{
    /// <summary>
    /// 变更文档类
    /// </summary>
    public class Document
    {
        public int ID { get; set; }//编号
        public bool IsCheck { get; set; }//是否选中
        public string Code { get; set; }//文档编号
        public string Name { get; set; }//文档名称
        public string Type { get; set; }//文档类型
        public string Version { get; set; }//文档版本
        public string Extension { get; set; }//文档扩展名
        public string FailureTime { get; set; }//失效时间
        public string EffectTime { get; set; }//生效时间
        public string State { get; set; }//文档状态 U:unread, O:over, R:read
        public string SecurityLevel { get; set; }//保密级别
        public string Creator { get; set; }//创建人
        public string GrantTime { get; set; }//发放时间
        public string GrantPermissions { get; set; }//发放权限
    }
}
