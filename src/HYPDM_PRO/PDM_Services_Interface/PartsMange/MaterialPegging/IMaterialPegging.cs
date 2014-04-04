using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMaterialPegging
    {
        [OperationContract]
        Material ModifyMaterialcs(string name, string type, string number);

        [OperationContract]
        IList<Material> MP();  //设计BOM区信息

        [OperationContract]
        IList<Material> MB();  //设计BOM区零部件信息

        [OperationContract]
        IList<Material> WB();  //工作BOM区信息

        [OperationContract]
        IList<Material> WP();  //工作BOM区零部件信息

        [OperationContract]
        IList<Material> AW();  //装配工作区BOM信息

        [OperationContract]
        IList<Material> AP();  //装配工作区零部件信息

        [OperationContract]
        IList<Material> ProjectBOMPegging();  //设计BOM反查

        [OperationContract]
        IList<Material> WorkBOMPegging();  //工作BOM反查

        [OperationContract]
        IList<Material> AssembleWorkPegging();  //装配工作反查

    }
}
