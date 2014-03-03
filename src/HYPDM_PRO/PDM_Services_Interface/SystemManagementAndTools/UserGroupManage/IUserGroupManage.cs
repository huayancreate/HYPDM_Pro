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
        IList<Group> findGroup(String condition); //查找用户组
        [OperationContract]
         bool AddGroup(Group group);//添加用户
        [OperationContract]
        bool DeleteGroup(int groupID);


        
    }
}
