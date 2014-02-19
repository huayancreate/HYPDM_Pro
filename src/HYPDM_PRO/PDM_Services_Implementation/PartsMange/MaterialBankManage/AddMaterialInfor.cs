using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.PartsMange;


namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.PerCall, 
        Namespace = "PDM_Services_Implementation")]
    public class AddMaterialInfor : IAddMaterialInfor
    {
        public Materialcs GetAllMaterialcs(string name, string versions, string number, string type)
        {
            Materialcs M = new Materialcs();
            return M;
        }
    }
}
