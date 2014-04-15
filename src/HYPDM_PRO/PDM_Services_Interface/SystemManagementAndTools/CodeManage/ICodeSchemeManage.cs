using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;
namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface ICodeSchemeManage
    {
        [OperationContract]
         bool AddCodeScheme();
        [OperationContract]
         List<CodeScheme> findCodeScheme(); //查询编码方案
        [OperationContract]
         List<String> findCodeValue(String CodeSchemeID);//根据方案ID查询编码值
        


    }
}
