using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface ICheckResult
    {
        [OperationContract]
        IList<Material> GetMaterialcsMessage(); //得到物料信息

        [OperationContract]
        string SaveMaterialcs(int id);  //保存物料

        [OperationContract]
        string ExportMaterialcs(int id);   //导出查重结果
    }
}
