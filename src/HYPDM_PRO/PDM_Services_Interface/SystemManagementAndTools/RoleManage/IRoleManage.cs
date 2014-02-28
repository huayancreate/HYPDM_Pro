using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;

namespace PDM_Services_Interface
{
   [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IRoleManage
    {
        [OperationContract]
        bool AddRole(Role role);// 添加用户
    }
}
