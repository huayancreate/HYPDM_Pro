using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class AddType : DevExpress.XtraEditors.XtraForm
    {
        public MaterialType type;
        public AddType()
        {
            InitializeComponent();
        }

        private void AddType_Load(object sender, EventArgs e)
        {

        }

        private void PartsMange_MaterialBankManage_AddType_CancelType_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Close();
            }
        }
    }
}