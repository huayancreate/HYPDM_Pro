using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using WcfExtension;
using PDM_Entity.MyTaskBox;

namespace View_Winform.MyTaskBox
{
    public partial class Emails : DevExpress.XtraEditors.XtraForm
    {
        IMyTaskBoxService myTaskBoxService;
        public Emails()
        {
            InitializeComponent();
        }

        private void Emails_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1);
            myTaskBoxService = WcfServiceLocator.Create<IMyTaskBoxService>();
            tlEmailTree.DataSource = myTaskBoxService.getEmailTree();
        }

        private void tlEmailTree_Click(object sender, EventArgs e)
        {
            gcEmails.DataSource = myTaskBoxService.getMailReceivingByMyID(1);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var email = myTaskBoxService.GetEmailByID(1);
            lblSender.Text = "发件人: " + email.Sender + email.Saddress;
            lblRecipients.Text = "收件人: " + email.Recipients + email.Raddress;
            lblTopic.Text = "主题: " + email.Topic;
            mmeBody.Text = email.Body;
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            gcEmails.DataSource = myTaskBoxService.getMailReceivingByMyID(1);
            gcEmails.RefreshDataSource();
        }

        private void btnWriteMail_Click(object sender, EventArgs e)
        {
            var writeEmail = new WriteEmail();
            writeEmail.Text = "写邮件";
            writeEmail.Show();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            var writeEmail = new WriteEmail();
            writeEmail.Text = "回复:";
            writeEmail.Email = myTaskBoxService.GetEmailByID(1);
            writeEmail.State = 1;
            writeEmail.ShowDialog();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            var writeEmail = new WriteEmail();
            writeEmail.Text = "回复:";
            writeEmail.Email = myTaskBoxService.GetEmailByID(1);
            writeEmail.State = 1;
            writeEmail.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            myTaskBoxService.RemoveEmailByID(1);
            gcEmails.DataSource = myTaskBoxService.getMailReceivingByMyID(1);
            gcEmails.RefreshDataSource();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gcEmails.DataSource = myTaskBoxService.getMailReceivingByMyID(1);
            gcEmails.RefreshDataSource();
        }
    }
}