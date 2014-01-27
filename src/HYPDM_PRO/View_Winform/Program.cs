using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace View_Winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");

            //Application.Run(new SystemManagementAndTools.SystemUserMessageManage.UserMessage());
            //Application.Run(new SystemManagementAndTools.RoleManege.RoleManage());
            //Application.Run(new SystemManagementAndTools.OrganizationManage.OrganizationManage()); 
            //Application.Run(new DocManage.DocPnt.DocPrint());
             Application.Run(new View_Winform.SystemManagementAndTools.RoleManage.RoleManage());
        }
    }
}