using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.ProjectManage;
using PDM_Services_Interface;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class PersonnelTaskInquireService : IPersonnelTaskInquireService
    {
        public List<GroupBo> getAllUserGroups()
        {
            List<GroupBo> gs = new List<GroupBo>();

            gs.Add(new GroupBo(1, "管理员"));
            gs.Add(new GroupBo(2, "生产线一"));
            gs.Add(new GroupBo(3, "生产线二"));
            gs.Add(new GroupBo(4, "研发组"));
            gs.Add(new GroupBo(1, "陈小尼", "管理员"));
            return gs;
        }

        public List<GroupBo> getUserGroupsByName(string username)
        {
            List<GroupBo> gs = new List<GroupBo>();
            gs.Add(new GroupBo(1, "管理员"));
            gs.Add(new GroupBo(1, "陈小尼", "管理员"));
            return gs;
        }

        public List<TaskBo> getTasks(int id, string starttime, string endtime, int state)
        {
            List<TaskBo> tasks = new List<TaskBo>();
            TaskBo t = new TaskBo();
            t.Name = "杀猪10头";
            t.WhichProductName = "";
            t.StartTime = "2014-02-14 08:30:00";
            t.EndTime = "2014-02-14 17:30:00";
            t.Type = "零星任务";
            t.Percent = 50;
            t.State = "执行";
            tasks.Add(t);
            return tasks;
        }
    }
}
