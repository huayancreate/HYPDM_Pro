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
    public class MaterialPropertyBuild : IMaterialPropertyBuild
    {
        public Materialcs GetMaterialcsBuild(string name, string type)
        {
            Materialcs Mate = new Materialcs();
            return Mate;
        }

        public int  AddMaterialcsBuild(int x, int y)
        {
            x = x + y;
            return x;
        }

        public IList<Materialcs> Mate() 
        {
            IList<Materialcs> Mate = new List<Materialcs>();
            Materialcs M = new Materialcs();
            Materialcs Ma= new Materialcs();
            M.cn_name = "轴承";
            Ma.widgh = "50px";
           
            return Mate;
        }
    }
       
}
