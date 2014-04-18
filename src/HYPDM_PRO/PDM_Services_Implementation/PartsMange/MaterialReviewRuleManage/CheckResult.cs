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
    public class CheckResult : ICheckResult
    {
        public IList<Material> GetMaterialcsMessage() 
        {
            IList<Material> list = new BindingList<Material>();
            Material M = new Material();
            Material Ma = new Material();
            Material Mb = new Material();
            //M.number = "1";
            //Ma.number = "2";
            //Mb.number = "3";


            list.Add(M);
            list.Add(Ma);
            list.Add(Mb);
            return list;
        }

        public string SaveMaterialcs(int id) 
        {
            return "";
        }

        public string ExportMaterialcs(int id) 
        {
            return "";
        }
    }
}
