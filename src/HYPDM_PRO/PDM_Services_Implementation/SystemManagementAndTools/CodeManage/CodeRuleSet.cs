using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;

namespace PDM_Services_Implementation
{
      [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
   public class CodeRuleSet : ICodeRuleSet
    {
          public bool AddCodeRule()
          {
              return false;
          }
    }
}
