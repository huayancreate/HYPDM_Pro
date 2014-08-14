using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.MyTaskBox;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.MyTaskBox
{
    public partial class WriteEmail : DevExpress.XtraEditors.XtraForm
    {
        public Email Email { get; set; }
        public int State { get; set; }
        IMyTaskBoxService myTaskBoxService;
        public WriteEmail()
        {
            InitializeComponent();
        }

        private void WriteEmail_Load(object sender, EventArgs e)
        {
            myTaskBoxService = WcfServiceLocator.Create<IMyTaskBoxService>();
            if (State == 1)
            {
                teSender.Text = "陈小尼<xnchen@pdm.com>;";
                teAcceptor.Text = Email.Recipients + "<" + Email.Raddress + ">";
                teTopic.Text = "回复:" + Email.Topic;
                memoEdit1.Text = Environment.NewLine + 
                    "发件人: " + Email.Sender + "<" + Email.Saddress + ">" + Environment.NewLine + 
                    "发送时间: " + Email.SendTime + Environment.NewLine+
                    "收件人: " + Email.Recipients + "<" + Email.Raddress + ">" + Environment.NewLine +
                    "主题: " + Email.Topic + Environment.NewLine + Email.Body;
            }
            if (State == 2)
            {
                teSender.Text = "陈小尼<xnchen@pdm.com>;";
                teTopic.Text = "转发:" + Email.Topic;
                memoEdit1.Text = Environment.NewLine +
                    "发件人: " + Email.Sender + "<" + Email.Saddress + ">" + Environment.NewLine +
                    "发送时间: " + Email.SendTime + Environment.NewLine +
                    "收件人: " + Email.Recipients + "<" + Email.Raddress + ">" + Environment.NewLine +
                    "主题: " + Email.Topic + Environment.NewLine + Email.Body;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            myTaskBoxService.SaveEmailByMyID(1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myTaskBoxService.SendEmailByMyID(1);
        }
    }
}