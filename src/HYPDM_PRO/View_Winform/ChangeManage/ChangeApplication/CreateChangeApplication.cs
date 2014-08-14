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

namespace View_Winform.ChangeManage.ChangeApplication
{
    public partial class CreateChangeApplication : InitService
    {
        public CreateChangeApplication()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var attr = new Hashtable() { };
            service.CreateChangeApplication(attr);
        }
    }
}