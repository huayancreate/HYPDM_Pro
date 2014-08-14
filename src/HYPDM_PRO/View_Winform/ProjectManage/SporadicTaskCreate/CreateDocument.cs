using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    public partial class CreateDocument : DevExpress.XtraEditors.XtraForm
    {
        public Hashtable documentInfomation { get; set; }
        public CreateDocument()
        {
            InitializeComponent();
        }

        private void CreateDocument_Load(object sender, EventArgs e)
        {
            beDocumentCode.Text = documentInfomation["Code"] as string;
            teDocumentName.Text = documentInfomation["Name"] as string;
            beDocumentProcess.Text = documentInfomation["Process"] as string;
            teDocumentVersion.Text = documentInfomation["Version"] as string;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            documentInfomation.Clear();
            documentInfomation.Add("Code", beDocumentCode.Text);
            documentInfomation.Add("Version", teDocumentVersion.Text);
            documentInfomation.Add("Name", teDocumentName.Text);
            documentInfomation.Add("Type", beDocumentType.Text);
            documentInfomation.Add("Process", beDocumentProcess.Text);
            documentInfomation.Add("FullName", beFileFullName.Text);
            documentInfomation.Add("Format", teDocumentFormat.Text);
            documentInfomation.Add("Page", teDocumentPage.Text);
            documentInfomation.Add("Creator", teCreator.Text);
            documentInfomation.Add("CreateTime", teCreateTime.Text);
            documentInfomation.Add("Confidential", cbeDocumentConfidential.Text);
            documentInfomation.Add("Remark", mmeRemark.Text);
            documentInfomation.Add("Keyword", mmeKeyword.Text);
            documentInfomation.Add("Summary", mmeSummary.Text);
            Close();
        }
    }
}