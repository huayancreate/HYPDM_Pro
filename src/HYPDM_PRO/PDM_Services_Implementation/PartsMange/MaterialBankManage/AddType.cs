using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;

namespace PDM_Services_Implementation
{
     [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class AddType : IAddType
    {
         public Materialcs GetAllMaterialcs(string name, string versions, string number, string type)
         {
             Materialcs M = new Materialcs();
             return M;
         } 
    }
}
