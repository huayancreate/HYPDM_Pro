using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using PDM_Entity.MyTaskBox;

namespace View_Winform.MyTaskBox
{
    public partial class SettingPersonalInformation : DevExpress.XtraEditors.XtraForm
    {
        IMyTaskBoxService mytaskboxservice;
        public SettingPersonalInformation()
        {
            InitializeComponent();
        }

        private void SettingPersonalInformation_Load(object sender, EventArgs e)
        {
            mytaskboxservice = WcfExtension.WcfServiceLocator.Create<IMyTaskBoxService>();
            PackageCommon.SettingTreeList(tlRoles);
            tlRoles.DataSource = mytaskboxservice.GetRolesByUserID(1);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var changepassword = new ChangePassword();
            changepassword.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            User user = new User();
            mytaskboxservice.SettingUserInfomation(user);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}