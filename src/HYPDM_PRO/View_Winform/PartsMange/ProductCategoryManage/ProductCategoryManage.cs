using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using WcfExtension;
using BP.Port;
using DevExpress.XtraTreeList.Nodes;
using View_Winform.PartsMange.ProductCategoryManage;
using DevExpress.XtraTreeList;


namespace View_Winform.PartsMange.ProductCategoryManage
{
    public partial class ProductCategoryManage : DevExpress.XtraEditors.XtraForm
    {
        IProductCategoryManage categoryService = WcfServiceLocator.Create<IProductCategoryManage>();
        private List<ProductCategory> categoryList = new List<ProductCategory>();
        public ProductCategoryManage()
        {
            InitializeComponent();
            gridView1 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView1, true);
            gridView2 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView2, true);
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList =
                BaseControls.BaseTreeListControl.BaseTreeListControlSetting(PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList, true);
        }

        private void ProductCategoryManage_Load(object sender, EventArgs e)
        {
            barManager1.ItemClick += CategoryItemClick;
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.AfterFocusNode += TreeListFocusNode;
            categoryList = categoryService.GetAllProductCategory();
            TreeDataBind(categoryList);
        }

        private void TreeListFocusNode(object sender, NodeEventArgs e)
        {
            BindProductCategory();
        }

        private void CategoryItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "btnCategoryAdd":
                    AddProductCategory(Convert.ToInt32(ParentId));
                    break;
                case "btnCategoryChildAdd":
                    AddProductCategory(Convert.ToInt32(Id));
                    break;
                case "btnCategoryEdit":
                    var modifyCategory = new AddProductCategory();
                    var category = categoryList.Find(c => c.id == Convert.ToInt32(Id));
                    modifyCategory.productCategory = category;
                    modifyCategory.Tag = "modify";
                    modifyCategory.ShowDialog();
                    if (modifyCategory.DialogResult == DialogResult.OK)
                    {
                        TreeDataBind(categoryList);
                    }
                    break;
                case "btnCategoryDelete":
                    category = categoryList.Find(c => c.id == Convert.ToInt32(Id));
                    categoryList.Remove(category);
                    TreeDataBind(categoryList);
                    //categoryService.DeleteCategory(Convert.ToInt32(Id));
                    break;
            }
        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_Query_SimpleButton_Click(object sender, EventArgs e)
        {
            SearchProductCategory();
        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            var treeList = (TreeList)sender;
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None))
            {
                var hitInfo = treeList.CalcHitInfo(e.Location);
                if (hitInfo.Node == null) return;
                treeList.SetFocusedNode(hitInfo.Node);
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_Find_SimpleButton_Click(object sender, EventArgs e)
        {

        }

        private object Id
        {
            get
            {
                if (PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.FocusedNode != null)
                    return PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.FocusedNode.GetValue(CategoryId);
                return null;
            }
        }

        private object ParentId
        {
            get
            {
                if (PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.FocusedNode != null)
                    return PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.FocusedNode.GetValue(Parent_Id);
                return null;
            }
        }

        private void TreeDataBind(List<ProductCategory> categoryList)
        {
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.Nodes.Clear();
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.DataSource = categoryList;
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.KeyFieldName = "id";
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.ParentFieldName = "parent_id";
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.ExpandAll();
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.RefreshDataSource();
        }

        private void AddProductCategory(int parentId)
        {
            var addCategory = new AddProductCategory();
            var category = new ProductCategory();
            category.parent_id = parentId;
            addCategory.productCategory = category;
            addCategory.ShowDialog();
            if (addCategory.DialogResult == DialogResult.OK)
            {
                categoryList.Add(addCategory.productCategory);
                TreeDataBind(categoryList);
            }
        }

        private void SearchProductCategory()
        {
            var dt = categoryService.GetProductByCategoryId(0);
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductMessageType_GridControl.DataSource = dt;
            //PartsMange_ProductCategoryManage_ProductCategoryManage_RelevanceProductMessage_GridControl = null;
        }

        private void BindProductCategory()
        {
            var dt = categoryService.GetProductByCategoryId(0);
            PartsMange_ProductCategoryManage_ProductCategoryManage_RelevanceProductMessage_GridControl.DataSource = dt;
        }
    }

}
