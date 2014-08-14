using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.ProjectManage;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IPersonnelTaskInquireService
    {
        [OperationContract]
        List<GroupBo> getAllUserGroups();

        [OperationContract]
        List<GroupBo> getUserGroupsByName(string username);

        [OperationContract]
        List<TaskBo> getTasks(int id, string starttime,string endtime,int state);
    }
}
