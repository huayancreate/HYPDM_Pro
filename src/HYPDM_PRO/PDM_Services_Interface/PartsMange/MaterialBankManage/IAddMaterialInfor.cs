using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;



namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IAddMaterialInfor
    {
        [OperationContract]
        IList<MaterialBaseProperty> MaterialMessage(int id);  //  物料信息

        [OperationContract]
        bool SaveMaterial(int id);  //保存物料信息
    }  
}
 