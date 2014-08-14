using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using PDM_Services_Interface;

namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    public partial class CreateOfficeTask : DevExpress.XtraEditors.XtraForm
    {
        private Hashtable documentInfomation;
        public CreateOfficeTask()
        {
            InitializeComponent();
            documentInfomation = new Hashtable();
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            documentInfomation["Code"] = beDocumentCode.Text;
            documentInfomation["Name"] = teDocumentName.Text;
            documentInfomation["Process"] = beDocumentProcess.Text;
            documentInfomation["Version"] = teDocumentVersioin.Text;
            documentInfomation["Remark"] = mmeRemark.Text;
            var document = new CreateDocument();
            document.documentInfomation = documentInfomation;
            document.ShowDialog();
            beDocumentCode.Text = documentInfomation["Code"] as string;
            teDocumentName.Text = documentInfomation["Name"] as string;
            beDocumentProcess.Text = documentInfomation["Process"] as string;
            teDocumentVersioin.Text = documentInfomation["Version"] as string;
            mmeRemark.Text = documentInfomation["Remark"] as string;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (documentInfomation.Count > 0)
            {
                documentInfomation["MultiplayerMissions"] = ceMultiplayerMissions.Checked;
                documentInfomation["SubmitTask"] = ceSubmitTask.Checked;
                WcfExtension.WcfServiceLocator.Create<ISporadicTaskCreateService>().saveOfficeTask(documentInfomation);
                Close();
            }
            else
            {
                MessageBox.Show("请将信息填写完整!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}