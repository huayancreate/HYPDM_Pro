using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.SystemManagementAndTools.MenuManagement
{
    public partial class MenuList : DevExpress.XtraEditors.XtraForm
    {
        public MenuList()
        {
            InitializeComponent();
        }

        private void SystemManagementAndTools_RoleList_QueryRole_SimpleButton_Click(object sender, EventArgs e)
        {
            bool ok = WcfServiceLocator.Create<IMenuManagement>().addMenu();
            MessageBox.Show(ok.ToString());
        }

       
    }
}