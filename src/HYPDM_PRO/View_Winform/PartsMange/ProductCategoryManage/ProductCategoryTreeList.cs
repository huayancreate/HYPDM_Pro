using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using WcfExtension;
using PDM_Entity.PartsMange;

namespace View_Winform.PartsMange.ProductCategoryManage
{
    public partial class ProductCategoryTreeList : DevExpress.XtraEditors.XtraForm
    {
        IProductCategoryManage categoryService = WcfServiceLocator.Create<IProductCategoryManage>();
        private List<ProductCategory> categoryList = new List<ProductCategory>();
        public ProductCategory productCategory { get; set; }
        public ProductCategoryTreeList()
        {
            InitializeComponent();
            treeList1 = BaseControls.BaseTreeListControl.BaseTreeListControlSetting(treeList1, true);
        }

        private void ProductCategoryTreeList_Load(object sender, EventArgs e)
        {
            simpleButton1.Click += ChooseCategoryClick;
            simpleButton2.Click += FormClose;
            categoryList = categoryService.GetAllProductCategory();
            TreeDataBind(categoryList);
        }

        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseCategoryClick(object sender, EventArgs e)
        {
            var id = treeList1.FocusedNode.GetValue(CategoryId);
            productCategory = categoryList.Find(c => c.id == Convert.ToInt32(id));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TreeDataBind(List<ProductCategory> categoryList)
        {
            treeList1.Nodes.Clear();
            treeList1.DataSource = categoryList;
            treeList1.KeyFieldName = "id";
            treeList1.ParentFieldName = "parent_id";
            treeList1.ExpandAll();
            treeList1.RefreshDataSource();
        }
    }
}