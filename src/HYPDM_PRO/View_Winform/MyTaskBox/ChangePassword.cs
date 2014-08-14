using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;

namespace View_Winform.MyTaskBox
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            WcfExtension.WcfServiceLocator.Create<IMyTaskBoxService>().ChangePasswordByUserID(1, "");
        }
    }
}