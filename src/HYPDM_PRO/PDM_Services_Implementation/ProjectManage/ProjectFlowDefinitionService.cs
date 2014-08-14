using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using PDM_Entity.ProjectManage;
using System.ServiceModel;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ProjectFlowDefinitionService : IProjectFlowDefinitionService
    {
        public List<ProjectProcessbo> getAllProjectProcess()
        {
            var pps = new List<ProjectProcessbo>();
            pps.Add(new ProjectProcessbo() { Id = 1, Name = "004", Version = "00", Creator = "陈小尼", CreateTime = "2014-03-15 14:11:36", State = "有效" });
            pps.Add(new ProjectProcessbo() { Id = 1, Name = "0012", Version = "00", Creator = "陈小尼", CreateTime = "2014-03-15 16:32:51", State = "无效" });
            pps.Add(new ProjectProcessbo() { Id = 1, Name = "0013", Version = "00", Creator = "陈小尼", CreateTime = "2014-03-15 17:22:51", State = "无效" });
            pps.Add(new ProjectProcessbo() { Id = 1, Name = "车身设计流程", Version = "00", Creator = "系统管理员", CreateTime = "2014-03-16 17:29:51", State = "无效" });
            return pps;
        }
        public List<ProjectProcessbo> getProjectProcessByUserId(int userid)
        {
            var pps = new List<ProjectProcessbo>();
            pps.Add(new ProjectProcessbo() { Id = 1, Name = "004", Version = "00", Creator = "陈小尼", CreateTime = "2014-03-15 14:11:36", State = "有效" });
            pps.Add(new ProjectProcessbo() { Id = 1, Name = "0012", Version = "00", Creator = "陈小尼", CreateTime = "2014-03-15 16:32:51", State = "无效" });
            pps.Add(new ProjectProcessbo() { Id = 1, Name = "0013", Version = "00", Creator = "陈小尼", CreateTime = "2014-03-15 17:22:51", State = "无效" });
            return pps;
        }

    }
}