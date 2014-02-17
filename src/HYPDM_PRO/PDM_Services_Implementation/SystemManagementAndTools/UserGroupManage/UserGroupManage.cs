using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;
using PDM_Services_Interface;


namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class UserGroupManage : IUserGroupManage
    {
        public Group getAllGroups(int id, String name, String remark)
        {
            Group g = new Group();
            return g;
        }
    }
}
