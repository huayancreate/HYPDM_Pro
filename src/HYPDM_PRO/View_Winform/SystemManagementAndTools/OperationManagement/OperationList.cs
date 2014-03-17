using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.SystemManagementAndTools.OperationManagement
{
    public partial class OperationList : Form
    {
        public OperationList()
        {
            InitializeComponent();
        }

        private void SystemManagementAndTools_RoleList_QueryRole_SimpleButton_Click(object sender, EventArgs e)
        {
            bool ok = WcfServiceLocator.Create<IOperationManagement>().addOperation();
            MessageBox.Show(ok.ToString());
        }
       
    }
}
