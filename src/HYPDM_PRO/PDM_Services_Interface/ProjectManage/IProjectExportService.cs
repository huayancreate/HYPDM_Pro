using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.ProjectManage;
using System.Collections;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IProjectExportService
    {
        [OperationContract]
        List<ProjectBo> getAllProjects();

        [OperationContract]
        List<ProjectBo> getProjectsBySomeField(Hashtable condition);

        [OperationContract]
        List<ProjectTypeBo> getAllProjectTypes();

        [OperationContract]
        List<ProjectBo> getProjectsByGroupId(int groupid);
    }
}
