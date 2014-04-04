using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IAddMaterialProperty
    {
        [OperationContract]
        bool AddMaterial(int id);  //添加物料属性

        [OperationContract]
        IList<MaterialBaseProperty> Mat();  //物料属性

        [OperationContract]
        bool DeleteMaterialType(int id);  //删除物料分类

        [OperationContract]
        IList<MaterialType> MT();  

    }
}
