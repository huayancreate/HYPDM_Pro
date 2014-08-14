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
    public class SporadicTaskCreateService : ISporadicTaskCreateService
    {
        public List<TaskTypebo> getAllTaskTypes()
        {
            var tasktypes = new List<TaskTypebo>();
            tasktypes.Add(new TaskTypebo() { ID = 1, Name = "设计任务" });
            tasktypes.Add(new TaskTypebo() { ID = 2, Name = "办公任务" });
            tasktypes.Add(new TaskTypebo() { ID = 3, Name = "工艺任务" });
            return tasktypes;
        }



        public bool saveProjectTask(System.Collections.Hashtable hashtable)
        {
            return false;
        }

        public bool saveOfficeTask(System.Collections.Hashtable hashtable)
        {
            return false;
        }

        public bool saveTechnologyTask(System.Collections.Hashtable hashtable)
        {
            return false;
        }
    }
}
