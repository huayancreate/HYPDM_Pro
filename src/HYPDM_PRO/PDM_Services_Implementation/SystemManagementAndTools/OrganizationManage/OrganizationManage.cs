using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;

namespace PDM_Services_Implementation
{
       [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class OrganizationManage :IOrganizationManage
    {
        public bool AddOrganization()
        {
            return false;
        }
        public List<Organization> findOrganization(String condition)
        {
            List<Organization> organization = new List<Organization>();

            Organization o1 = new Organization();
            o1.name = "顶级目录";
            o1.Id = 1;
            o1.ParentID = 0;
            o1.Coding = "1000";

            Organization o2 = new Organization();
            o2.name = "二级目录";
            o2.Id = 2;
            o2.ParentID = 1;
            o2.Coding = "1001";

            Organization o3 = new Organization();
            o3.name = "二级目录2";
            o3.Id = 3;
            o3.ParentID = 1;
            o3.Coding = "1002";

            Organization o4 = new Organization();
            o4.name = "三级目录";
            o4.Id = 4;
            o4.ParentID = 3;
            o4.Coding = "1003";

            organization.Add(o1);
            organization.Add(o2);
            organization.Add(o3);
            organization.Add(o4);

            return organization;

        }
    }
}
