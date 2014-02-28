using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Entity.SystemManagementAndTools;
using PDM_Services_Interface;



namespace View_Winform.SystemManagementAndTools.RoleManage
{
    public partial class RoleList : DevExpress.XtraEditors.XtraForm
    {
        public RoleList()
        {
            InitializeComponent();
        }

        private void SystemManagementAndTools_RoleList_QueryRole_SimpleButton_Click(object sender, EventArgs e)
        {
            Role role=new Role();
            role.id = 1;
            role.name = "s";
            bool ok=true;
            ok=WcfServiceLocator.Create<IRoleManage>().AddRole(role);
            MessageBox.Show(ok.ToString());
        }

        private void RoleList_Load(object sender, EventArgs e)
        {

        }

        private void RoleList_Load_1(object sender, EventArgs e)
        {

        }
    }
}