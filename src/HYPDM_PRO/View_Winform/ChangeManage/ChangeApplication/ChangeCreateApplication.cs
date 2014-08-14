using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.ChangeManage.ChangeApplication
{
    public partial class ChangeCreateApplication : InitService
    {
        public ChangeCreateApplication()
        {
            InitializeComponent();
        }

        private void ChangeCreateApplication_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1);
            PackageCommon.SettingGridView(gridView2);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void teChangeApplication_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var changeApplication = new CreateChangeApplication();
            changeApplication.ShowDialog();
        }

        private void btnChooseDocument_Click(object sender, EventArgs e)
        {
            var chooseDocument = new FindDocument();
            chooseDocument.ShowDialog();
        }
    }
}