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
    public partial class CreateProductDeploy : DevExpress.XtraEditors.XtraForm
    {
        public OutputInformationbo outputInformation;
        public CreateProductDeploy()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            outputInformation = new OutputInformationbo() { Number = "ffca", Name = teName.Text, Version = teVersion.Text, Type = "产品结构配置" };
            Close();
        }

        private void ceNeednt_CheckedChanged(object sender, EventArgs e)
        {
            beProcess.Enabled = !ceNeednt.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ceChooseExist_CheckedChanged(object sender, EventArgs e)
        {
            beRootCode.Properties.ReadOnly = ceChooseExist.Checked;
        }
    }
}