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
    public class ProjectService : IProjectService
    {
        public Project GetProject(){
            
            return null;
        }
        public string ProjectSave(Project project)
        {

            return "";
        }
    }
}
