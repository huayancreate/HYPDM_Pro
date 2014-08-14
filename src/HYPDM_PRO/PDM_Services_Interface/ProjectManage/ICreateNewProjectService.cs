using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.ProjectManage;
using PDM_Entity.MyTaskBox;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface ICreateNewProjectService
    {
        [OperationContract]
        string ProductSave(Product product);

        [OperationContract]
        string ProductModify(Product product);

        [OperationContract]
        bool ProductRemove(int id);

        [OperationContract]
        List<TreeNode> GetProjectRoles();

        [OperationContract]
        List<TreeNode> GetEmpoyeesByRoleID(int roleid);
    }
}
