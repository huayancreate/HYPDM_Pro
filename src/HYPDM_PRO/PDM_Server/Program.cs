using PDM_Services_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using WcfExtension;


namespace PDM_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);

 //         ServerManager.StartService(typeof(TestService));
            ServerManager.StartService(typeof(TestService2));
            //ServerManager.StartService(typeof(AddMaterialInfor));
           // ServerManager.StartService(typeof(AddType));
            //ServerManager.StartService(typeof(MaterialBankManage));

            /* the following code belong to SystemMangeAndTools module*/
            ServerManager.StartService(typeof(UsersManage));
            ServerManager.StartService(typeof(UserGroupManage));
            ServerManager.StartService(typeof(RoleManage));
            ServerManager.StartService(typeof(OrganizationManage));
            ServerManager.StartService(typeof(OperationManagement));
            ServerManager.StartService(typeof(MenuManagement));
            ServerManager.StartService(typeof(CodeApplyManage));
            ServerManager.StartService(typeof(CodeSchemeManage));
            ServerManager.StartService(typeof(CodeDictionaryFill));
            ServerManager.StartService(typeof(CodeRuleSet));

           

            //ServerManager.StartService(typeof(TestService));
            //ServerManager.StartService(typeof(TestService2));
            //ServerManager.StartService(typeof(UserGroupManage));
            //ServerManager.StartService(typeof(AddMaterialInfor));
            //ServerManager.StartService(typeof(MaterialBankManage));
            //ServerManager.StartService(typeof(MaterialPegging));
            // ServerManager.StartService(typeof(AddMaterialProperty));
            //ServerManager.StartService(typeof(MaterialPropertyBuild));

            Console.WriteLine("TestService Started...");
            Console.ReadLine();
        }
    }
}
