using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;

namespace PDM_Services_Implementation
{
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class CodeSchemeManage : ICodeSchemeManage
    {
       public bool AddCodeScheme()
       {
           return false;
       }

       public List<CodeScheme> findCodeScheme()
       {
           List<CodeScheme> list = new List<CodeScheme>();
           CodeScheme code = new CodeScheme();
           code.id = 1;
           code.name = "通用编码";
           code.remark = "这是通用编码方案";
           code.status = "0";

           CodeScheme code1 = new CodeScheme();
           code1.id = 2;
           code1.name = "文档编码";
           code1.remark = "这是文档编码方案";
           code1.status = "0";

           list.Add(code);
           list.Add(code1);

           return list;
         
       }
       public List<String> findCodeValue(String CodeSchemeID)
       {
           List<String> list = new List<string>();
           list.Add("123");
           list.Add("124");
           
           list.Add("125");
           list.Add("126");
           return list;
       }
    }
}
