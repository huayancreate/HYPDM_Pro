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
   public class CodeRuleSet : ICodeRuleSet
    {
          public bool AddCodeRule(CodeRuleCodes code, int CodeSchemeID)
          {
              return false;
          }

          public  List<CodeRuleCodes> findCodeRule(int CodeSchemeID)
          {
              List<CodeRuleCodes> list = new List<CodeRuleCodes>();
              
              CodeRuleCodes code1 = new CodeRuleCodes();
             
                code1.name = "没有成文规则1";
                code1.type = 0;
                code1.remark = "逻辑好模糊的说1";
                code1.digit = 3;
              

              CodeRuleCodes code2 = new CodeRuleCodes();
              
                code2.name = "没有成文规则2";
                code2.type = 1;
                code2.remark = "逻辑好模糊的说2";
                code2.digit = 2;

              CodeRuleCodes code3 = new CodeRuleCodes();
                code3.name = "没有成文规则3";
                code3.type = 2;
                code3.remark="逻辑好模糊的说3";
                code3.digit = 4;

              CodeRuleCodes code4 = new CodeRuleCodes();
              
                code4.name = "没有成文规则3";
                code4.type = 3;
                code4.remark = "逻辑好模糊的说4";
                code4.digit = 3;
              
                list.Add(code1);
                list.Add(code2);
                list.Add(code3);
                list.Add(code4);
              
                for (int i = 0; i < list.Count;i++ ) 
                {
                   switch(list[i].type){
                       case 0:
                           list[i].typeToString = "常规码";
                           break;
                       case 1:
                           list[i].typeToString="预制码";
                           break;
                       case 2:
                           list[i].typeToString = "占位码";
                           break;
                       case 3:
                           list[i].typeToString = "流水码";
                           break;
                           
                   }
                   
                }
                return list;
            }

         public bool modifyCodeRuleSet(CodeRuleCodes codes)
         {
             return false;
         }
         public List<common_number> findCommonCodeGroup()
         {
             List<common_number> list = new List<common_number>();
             common_number comm = new common_number();
             comm.group_name = "文档设计编码组";
             comm.id = 1;
             comm.parent_id = 0;

             common_number comm1 = new common_number();
             comm1.group_name = "文档设计编码组1";
             comm1.id = 2;
             comm1.parent_id = 1;

             common_number comm2 = new common_number();
             comm2.group_name = "文档设计编码组2";
             comm2.id = 3;
             comm2.parent_id = 1;

             common_number comm3 = new common_number();
             comm3.group_name = "图纸设计编码组";
             comm3.id = 4;
             comm3.parent_id = 0;

             common_number comm4 = new common_number();
             comm4.group_name = "图纸设计编码组1";
             comm4.id = 5;
             comm4.parent_id = 4;

             common_number comm5 = new common_number();
             comm5.group_name = "图纸设计编码组2";
             comm5.id = 6;
             comm5.parent_id = 4;

             list.Add(comm);
             list.Add(comm1);
             list.Add(comm2);
             list.Add(comm3);
             list.Add(comm4);
             list.Add(comm5);

             return list;

         }
         public bool addCommonGroup(common_number common) 
         {
             return false;
         }
    }
}
