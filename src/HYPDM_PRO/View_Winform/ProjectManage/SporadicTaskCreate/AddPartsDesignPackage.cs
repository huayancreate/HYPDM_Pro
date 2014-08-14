using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProjectManage;

namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    public partial class AddPartsDesignPackage : DevExpress.XtraEditors.XtraForm
    {
        public OutputInformationbo outputInformation { get; set; }
        public AddPartsDesignPackage()
        {
            InitializeComponent();
        }

        private void ceNeednt_CheckedChanged(object sender, EventArgs e)
        {
            beProcess.Enabled = !ceNeednt.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            outputInformation = new OutputInformationbo() { Name = teName.Text, Type = "零部件设计包" };
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}