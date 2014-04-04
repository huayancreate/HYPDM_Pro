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
        public ProductCategory PC;
        public AddProductCategory()
        {
            InitializeComponent();
        }

        private void PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton_MouseDown(object sender, MouseEventArgs e)
        {

            if(e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton_Click(object sender, EventArgs e)
        {   

            /*if(PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Tag == "name")
            {
                IList<ProductCategory> AD = new BindingList<ProductCategory>();
                ProductCategory p = new ProductCategory();

                //string name = PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Tag.ToString();  
            }

            else
            {
                MessageBox.Show("类名不能为空，请添加类名！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.None);
            }*/
        }


    }
}