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
        Material GetMaterialcsBuild(string name, string type);

        [OperationContract]
        int  AddBuild(int x, int y);

       //[OperationContract]
       //string DeleteMaterialcsBuild(int id);

       //[OperationContract]
       //string ModifyMaterialcsBuild(int id);

        [OperationContract]
        IList<MaterialBaseProperty> Mate(); //物料属性

        [OperationContract]
        bool  DeleteMaterialBuild(int id);  //删除属性


        


    }
}
