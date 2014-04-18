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


namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class ProductCategoryManage : Form
    {
        public ProductCategoryManage()
        {
            InitializeComponent();
        }

        private void ProductCategoryManage_Load(object sender, EventArgs e)
        {
            IList<Material> p = new BindingList<Material>();

            p = WcfServiceLocator.Create<IProductCategoryManage>().product();

            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductMessageType_GridControl.DataSource = p;

            PartsMange_ProductCategoryManage_ProductCategoryManage_RelevanceProductMessage_GridControl.DataSource = p;
        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_Query_SimpleButton_Click(object sender, EventArgs e)
        {
            string status = PartsMange_ProductCategoryManage_ProductCategoryManage_ProductMessageType1_ComboBoxEditn.Tag.ToString();
            string type = PartsMange_ProductCategoryManage_ProductCategoryManage_ProductMessageType2_ComboBoxEditn.Tag.ToString();
            string versions = PartsMange_ProductCategoryManage_ProductCategoryManage_ProductMessageType3_ComboBoxEditn.Tag.ToString();
            string name = PartsMange_ProductCategoryManage_ProductCategoryManage_ProductMessageType_TextEdit.Tag.ToString();
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductMessageType_GridControl.DataSource =
                WcfServiceLocator.Create<IProductCategoryManage>().QueryProductMessage(status, type, versions, name);
        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None))
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void barButtonItem_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddProductCategory AP = new AddProductCategory();
            AP.Show();
        }

        private void barButtonItem_Modify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddProductCategory AP = new AddProductCategory();
            AP.Show();

            this.Node();
        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_Find_SimpleButton_Click(object sender, EventArgs e)
        {
            string name = PartsMange_ProductCategoryManage_ProductCategoryManage_Classify_TextEdit.Tag.ToString();
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.DataSource =
                WcfServiceLocator.Create<IProductCategoryManage>().QueryClassify(name);
        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void barButtonItem_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteClassify();
        }

        public void DeleteClassify()
        {

        }

        public void RegEvent()
        {
            PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.DoubleClick +=
                new EventHandler(PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList_DoubleClick);

        }

        private void PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList_DoubleClick(object sender, EventArgs e)
        {
            barButtonItem_Add.PerformClick();
        }

        public void Node()
        {
            if (PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.Nodes.Count == 0)
            {
                TreeListNode node = PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.AppendNode(new object[] { }, 2);
            }
            else
            {
                int T = Convert.ToInt32(PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.Nodes.LastNode.GetValue("ID"));
                TreeListNode node = PartsMange_ProductCategoryManage_ProductCategoryManage_ProductClassify_TreeList.AppendNode(new object[] { T + 1 }, -2);
            }
        }
    }

}
