using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using System.ComponentModel;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class AddUnitGroup : IAddUnitGroup
    {
        public bool SaveUnitGroup(UnitGroup S) 
        {
            IList<UnitGroup> List = new BindingList<UnitGroup>();
            
           
            
            return false;
        }
    }
}
