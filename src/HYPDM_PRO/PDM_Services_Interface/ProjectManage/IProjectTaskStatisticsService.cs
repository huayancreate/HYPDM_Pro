using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ServiceModel;
using PDM_Entity.ProjectManage;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IProjectTaskStatisticsService
    {
        [OperationContract]
        List<TaskAnalyzebo> getTasksAnalyze(Hashtable conditions);
    }
}
