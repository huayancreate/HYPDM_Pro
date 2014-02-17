using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IUserGroupManage
    {
        [OperationContract]
        Group getAllGroups(int id, String name, String remark); //获取所有用户信息

    }
}
