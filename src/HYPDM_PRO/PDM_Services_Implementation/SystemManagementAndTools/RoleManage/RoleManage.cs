using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Services_Interface;
using PDM_Entity.SystemManagementAndTools;
namespace PDM_Services_Implementation
{
     [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class RoleManage :IRoleManage
    {
         public bool AddRole(Role role)
         {
             return false;
         }
    }
}
