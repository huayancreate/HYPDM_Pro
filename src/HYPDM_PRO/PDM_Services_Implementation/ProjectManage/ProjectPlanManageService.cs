using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.ProjectManage;
using System.Collections;
using System.Data;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ProjectPlanManageService : IProjectPlanManageService
    {
        const string Day = "日一二三四五六";
        /// <summary>
        /// 创建产品配置
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public string createProductDeploy(Product product)
        {

            return "";
        }
        /// <summary>
        /// 获取任务树和任务执行状态
        /// </summary>
        /// <returns></returns>
        public List<TaskTree> getTaskTree()
        {
            List<TaskTree> tasks = new List<TaskTree>();
            TaskTree task = new TaskTree();
            task.ID = 1;
            task.Type = "J";
            task.Name = "华研PDM";
            task.State = "执行中";
            tasks.Add(task);
            TaskTree task1 = new TaskTree();
            task1.ID = 1;
            task1.Type = "D";
            task1.Name = "XXX-华研PDM";
            task1.ParentName = "华研PDM";
            task1.State = "执行中";
            tasks.Add(task1);
            TaskTree task2 = new TaskTree();
            task2.ID = 1;
            task2.Type = "A";
            task2.Name = "文档管理";
            task2.ParentName = "XXX-华研PDM";
            task2.State = "实例化未就绪";
            tasks.Add(task2);
            TaskTree task3 = new TaskTree();
            task3.ID = 2;
            task3.Type = "T";
            task3.Name = "零部件管理";
            task3.ParentName = "XXX-华研PDM";
            task3.State = "实例化未就绪";
            tasks.Add(task3);
            return tasks;
        }
        public DateTime[] getGanttCalendar(int projectid)
        {
            DateTime start = new DateTime(2013, 12, 12);
            DateTime end = new DateTime(2014, 4, 30);
            return new DateTime[] { start, end };
        }
        public bool addProjectDocument()
        {
            return false;
        }

        public bool saveTask(TaskBo task)
        {
            return false;
        }

        public List<ProjectGroupUser> getProjectGroupUsersByIdProjectId(int projectId)
        {
            var projectGroupUsers = new List<ProjectGroupUser>();
            projectGroupUsers.Add(new ProjectGroupUser() { Id = 1, Name = "许伟", Activity = "", Role = "系统管理员" });
            projectGroupUsers.Add(new ProjectGroupUser() { Id = 2, Name = "刘威", Activity = "", Role = "系统管理员" });
            projectGroupUsers.Add(new ProjectGroupUser() { Id = 3, Name = "陈小尼", Activity = "", Role = "系统管理员" });
            return projectGroupUsers;
        }

        public List<TaskBo> getTasksByProjectId(int projectid)
        {
            var tasks = new List<TaskBo>();
            tasks.Add(new TaskBo() { Id = 1, Name = "文档管理器", WhichProductName = "文档管理", PlanStartTime = "2014-01-01", PlanEndTime = "2014-01-10", StartTime = "2014-01-01", EndTime = "2014-01-10", Percent = 100, State = "已完成" });
            tasks.Add(new TaskBo() { Id = 2, Name = "文档模版管理器", WhichProductName = "文档管理", PlanStartTime = "2014-01-11", PlanEndTime = "2014-01-20", StartTime = "2014-11-01", EndTime = "2014-01-20", Percent = 100, State = "已完成" });
            return tasks;
        }
        public List<TaskBo> getTasksByUserId(int userid)
        {
            var tasks = new List<TaskBo>();
            tasks.Add(new TaskBo() { Id = 2, Name = "文档模版管理器", WhichProductName = "文档管理", PlanStartTime = "2014-01-11", PlanEndTime = "2014-01-20", StartTime = "2014-11-01", EndTime = "2014-01-20", Percent = 100, State = "已完成" });
            return tasks;
        }
    }
}
