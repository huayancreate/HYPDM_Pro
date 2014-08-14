
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 产品配置
    /// </summary>
    public class ProjectDeploybo
    {
        public int Id { get; set; }//编号
        public int RootId { get; set; }//根件编号
        public int ProcessId { get; set; }//流程编号
        public string ProjectName{get;set;}//产品名称
        public string ProjectVersion { get; set; }//产品版本
        public string ProjectType { get; set; }//产品类型
        public string RootCode { get; set; }//根件代号
        public string ChooseExist { get; set; }//已有件
        public string RootName { get; set; }//根件名称
        public string Creator { get; set; }//创建者
        public string CreateTime { get; set; }//创建时间
        public string ProcessName { get; set; }//流程名称
        public int Neednt { get; set; }//是否需要审签
    }
}
