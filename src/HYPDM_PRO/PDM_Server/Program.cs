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
            //ServerManager.StartService(typeof(TestService));
            //ServerManager.StartService(typeof(TestService2));
            //ServerManager.StartService(typeof(AddMaterialInfor));
            //ServerManager.StartService(typeof(AddType));
            //ServerManager.StartService(typeof(MaterialBankManage));

            /* the following code belong to SystemMangeAndTools module*/
            //ServerManager.StartService(typeof(UsersManage));
            //ServerManager.StartService(typeof(UserGroupManage));
            //ServerManager.StartService(typeof(RoleManage));
            //ServerManager.StartService(typeof(OrganizationManage));
            //ServerManager.StartService(typeof(OperationManagement));
            //ServerManager.StartService(typeof(MenuManagement));
            //ServerManager.StartService(typeof(CodeApplyManage));
            //ServerManager.StartService(typeof(CodeSchemeManage));
            //ServerManager.StartService(typeof(CodeDictionaryFill));
            //ServerManager.StartService(typeof(CodeRuleSet));
            //ServerManager.StartService(typeof(TestService));
            //ServerManager.StartService(typeof(TestService2));
            //ServerManager.StartService(typeof(UserGroupManage));
            //ServerManager.StartService(typeof(AddMaterialInfor));
            ServerManager.StartService(typeof(MaterialPropertyBuild));
            ServerManager.StartService(typeof(MaterialBankManage));
            ServerManager.StartService(typeof(MaterialPegging));
            ServerManager.StartService(typeof(AddMaterialProperty));
            ServerManager.StartService(typeof(ProductStruct));
            ServerManager.StartService(typeof(ProductCategoryManage));
            ServerManager.StartService(typeof(MeasurementUnitBuild));
            //ServerManager.StartService(typeof(DocManageTool));
            //ServerManager.StartService(typeof(DocGrantManage));
            //ServerManager.StartService(typeof(DocPropertyBuild));
            //ServerManager.StartService(typeof(DocSecurityLevelBuild));
            //ServerManager.StartService(typeof(DocTemplateCategoryManage));
            //SocketServer socket = new SocketServer("127.0.0.1", 7775);
            //socket.start();
            //ServerManager.StartService(typeof(ProductStruct));

            Console.WriteLine("TestService Started...");
            Console.ReadLine();
        }
    }
}
