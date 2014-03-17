using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Entity.SystemManagementAndTools;
using System.ServiceModel;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IUsersManage
    {
        [OperationContract]
        IList<Users> FindUser(String condition);//查询用户

        [OperationContract]
        bool AddUser(Users user);//添加用户
        [OperationContract]
        bool DeleteUser(int id);//删除用户
        [OperationContract]
        bool ModifyUser(Users user);//修改用户
        [OperationContract]
        IList<Role> FindRole(int id);//查找所属角色
        [OperationContract]
        bool AddRelatedGroup(int userID, int groupID);//添加用户与用户组关联
        [OperationContract]
        List<Users> FindRelatedUsersForUserGroup(int groupID);//查询和指定用户组关联的用户


    }
}
