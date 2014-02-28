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

namespace View_Winform.SystemManagementAndTools.OrganizationManage
{
    public partial class OrganizationList : DevExpress.XtraEditors.XtraForm
    {
        public OrganizationList()
        {
            InitializeComponent();
        }

        private void SystemManagementAndTools_OrganizationManage_OrganizationMessage_QueryOrganization_SimpleButtonl_Click(object sender, EventArgs e)
        {
            bool ok=WcfServiceLocator.Create<IOrganizationManage>().AddOrganization();
            MessageBox.Show(ok.ToString());
        }

    }
}