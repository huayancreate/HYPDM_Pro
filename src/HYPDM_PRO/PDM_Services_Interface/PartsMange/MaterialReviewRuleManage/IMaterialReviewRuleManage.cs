using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMaterialReviewRuleManage
    {
        [OperationContract]
        IList<RepeatRule> rep();  //得到查询结果信息

        [OperationContract]
        bool AddMaterialReviewRule(int id);  //添加物料查重规则

        [OperationContract]
        bool ModifyMaterialReviewRule(int id);  //修改物料查重规则

        [OperationContract]
        IList<RepeatRule> LookOverMaterialReviewRule(int id);  //查看物料查重规则

        [OperationContract]
        bool DeleteMaterialReviewRule(int id);  //删除物料查重规则
        
        [OperationContract]
        IList<RepeatRule> QueryMaterialReviewRule(string name, string is_strict, string remark);  //查询物料查重规则

        [OperationContract]
        string DuplicateChecking(int id); //查重规则
    }
}
