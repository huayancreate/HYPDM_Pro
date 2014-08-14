using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.Collections;
using System.ServiceModel;
using PDM_Entity.ProjectManage;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ProjectTaskStatisticsService : IProjectTaskStatisticsService
    {
        public List<TaskAnalyzebo> getTasksAnalyze(Hashtable conditions)
        {
            var taskAnalyzeList = new List<TaskAnalyzebo>();
            taskAnalyzeList.Add(new TaskAnalyzebo { State = "就绪", Count = 102 });
            taskAnalyzeList.Add(new TaskAnalyzebo { State = "执行", Count = 209 });
            taskAnalyzeList.Add(new TaskAnalyzebo { State = "完成", Count = 404 });
            return taskAnalyzeList;
        }
    }
}
