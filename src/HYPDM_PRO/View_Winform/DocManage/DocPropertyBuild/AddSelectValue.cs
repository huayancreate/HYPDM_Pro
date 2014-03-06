using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.DocManage.DocPropertyBuild
{
    public partial class AddSelectValue : DevExpress.XtraEditors.XtraForm
    {
        public String value { get; set; }
 
        public AddSelectValue()
        {
            InitializeComponent();
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            value = txtSelValue.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}