using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using System.Collections;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMaterialPropertyBuild
    {
        [OperationContract]
        Materialcs GetMaterialcsBuild(string name, string type);

        [OperationContract]
        int  AddMaterialcsBuild(int x, int y);

        //[OperationContract]
       // string DeleteMaterialcsBuild(int id);

        //[OperationContract]
       // string ModifyMaterialcsBuild(int id);

        [OperationContract]
        IList<Materialcs> Mate(); //物料属性

        

    }
}
