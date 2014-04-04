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
        IList<MaterialBaseProperty> MB();  //物料信息

        [OperationContract]
        IList<MaterialBaseProperty> QueryMaterial(); //查询

        [OperationContract]
        bool DeleteMaterialMessage(int id); //删除物料信息

        [OperationContract]
        IList<MaterialBaseProperty> ModifyMaterialMessage();  //修改信息
       

        
    }
}
