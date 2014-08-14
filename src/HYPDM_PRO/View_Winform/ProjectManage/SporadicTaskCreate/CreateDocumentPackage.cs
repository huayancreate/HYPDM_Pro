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
    public partial class CreateDocumentPackage : DevExpress.XtraEditors.XtraForm
    {
        public DocumentPackage documentPackage { get; set; }
        public OutputInformationbo outputinformation { get; set; }
        public CreateDocumentPackage()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            documentPackage = new DocumentPackage() { Id = 1, Name = teDocumentName.Text, Type = "零星任务文档" };
            outputinformation = new OutputInformationbo() { Name = teDocumentName.Text, Type = "零星任务文档"};
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
    }
}