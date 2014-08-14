using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace View_Winform.ChangeManage.ChangeMessageGroupManage
{
    public partial class AddGroup : DevExpress.XtraEditors.XtraForm
    {
        public Hashtable attr { get; set; }
        public AddGroup()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (teName.Text.Trim().Equals("")) return;
            attr["Name"] = teName.Text.Trim();
            attr["Description"] = teDescription.Text.Trim();
            Close();
        }
    }
}