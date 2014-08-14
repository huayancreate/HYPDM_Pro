using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using System.Collections;

namespace View_Winform.MyTaskBox
{
    public partial class ApplyCode : DevExpress.XtraEditors.XtraForm
    {
        public ApplyCode()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var condition = new Hashtable();
            WcfExtension.WcfServiceLocator.Create<IMyTaskBoxService>().ApplicationCodeByUserID(condition);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}