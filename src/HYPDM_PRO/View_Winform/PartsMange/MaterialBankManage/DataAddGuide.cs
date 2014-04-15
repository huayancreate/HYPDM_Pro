using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class DataAddGuide : DevExpress.XtraEditors.XtraForm
    {
        public DataAddGuide()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }
    }
}