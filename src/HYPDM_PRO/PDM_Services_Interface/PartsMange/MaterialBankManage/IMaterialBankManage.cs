using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMaterialBankManage
    {
        [OperationContract]
        List<Material> GetAllMaterial();  //物料信息
        [OperationContract]
        bool AddORUpdateType(Material_Type type);
        [OperationContract]
        List<Material_Type> GetAllMaterialType();
        [OperationContract]
        List<Material> GetMaterialByTypeId(int typeId);
    }
}
