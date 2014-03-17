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
        bool AddRole(Role role);// 添加角色
        [OperationContract]
        IList<Role> findRole(String condition); //查找角色
        [OperationContract]
        bool DeleteRole(int roleId);
        [OperationContract]
        List<Users> findRelatedUser(int roleId);
        [OperationContract]
        List<Group> findRelatedGroup(int roleId);
        [OperationContract]
        IList<Operation> findRelatedOperation(int roleId);
        [OperationContract]
        IList<Menus> findRelatedMenu(int roleId);
      
    

    }
}
