using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.ProjectManage;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class SporadicTaskManageService : ISporadicTaskManageService
    {
        public List<TaskBo> getSporadicTaskBySomeConditions(System.Collections.Hashtable Conditions)
        {
            var tasks = new List<TaskBo>();
            tasks.Add(new TaskBo() { Id = 1, Name = "底盘设计", Creator = "SS", Executor = "Ss", State = "就绪", ExecuteState = 1 });
            tasks.Add(new TaskBo() { Id = 1, Name = "底盘设计01", Creator = "SS", Executor = "Ss", State = "就绪", ExecuteState = 2 });
            tasks.Add(new TaskBo() { Id = 1, Name = "底盘设计02", Creator = "SS", Executor = "Ss", State = "就绪", ExecuteState = 3 });
            tasks.Add(new TaskBo() { Id = 1, Name = "底盘设计03", Creator = "SS", Executor = "Ss", State = "就绪", ExecuteState = 4 });
            return tasks;
        }

        public TaskBo getSporadicTaskById(int id)
        {
            var task = new TaskBo() { Id = 1, Name = "底盘设计", Creator = "SS", Executor = "Ss", State = "就绪", ExecuteState = 1 };
            return task;
        }

        public List<TaskTree> getTaskTreeBySomeConditions(System.Collections.Hashtable Conditions)
        {
            var tasktree = new List<TaskTree>();
            tasktree.Add(new TaskTree() { ID = 1, Name = "底盘设计" });
            tasktree.Add(new TaskTree() { ID = 2, Name = "底盘设计", ParentID = 1 });
            tasktree.Add(new TaskTree() { ID = 3, Name = "底盘设计", ParentID = 1 });
            tasktree.Add(new TaskTree() { ID = 4, Name = "底盘设计", ParentID = 1 });
            return tasktree;
        }
        public bool removeSporadicTaskById(int id)
        {
            return false;
        }
    }
}
