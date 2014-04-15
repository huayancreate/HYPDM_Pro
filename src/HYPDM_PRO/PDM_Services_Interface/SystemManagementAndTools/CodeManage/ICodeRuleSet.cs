using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface ICodeRuleSet
    {
        [OperationContract]
        bool AddCodeRule(CodeRuleCodes code,int CodeSchemeID);
        [OperationContract]
        List<CodeRuleCodes> findCodeRule(int CodeSchemeID);
        [OperationContract]
        bool modifyCodeRuleSet(CodeRuleCodes codes);
        [OperationContract]
        List<common_number> findCommonCodeGroup();
        [OperationContract]
        bool addCommonGroup(common_number common);
    }
}
