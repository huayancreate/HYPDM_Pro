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

namespace View_Winform.PartsMange.ProductCategoryManage
{
    public partial class AddProductCategory : DevExpress.XtraEditors.XtraForm
    {
        public ProductCategory productCategory { get; set; }
        public AddProductCategory()
        {
            InitializeComponent();
        }


        private void AddProductCategory_Load(object sender, EventArgs e)
        {

        }

        private void PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton_Click(object sender, EventArgs e)
        {
            productCategory.id = 10;
            productCategory.name = PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Text;
            productCategory.is_delete = "0";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}