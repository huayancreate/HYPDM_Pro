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
using DevExpress.XtraTreeList;
using System.Linq;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class MaterialBankManage : DevExpress.XtraEditors.XtraForm
    {
        IMaterialBankManage materialService = WcfServiceLocator.Create<IMaterialBankManage>();
        public Material Mod;
        public MaterialBaseProperty MaterBasePro;
        private List<Material_Type> materialTypeList = new List<Material_Type>();
        public MaterialBankManage()
        {
            InitializeComponent();
        }
        private void MaterialBankManage_Load(object sender, EventArgs e)
        {
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView, false);
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            barManager1.ItemClick += MaterialItemClick;
            barManager2.ItemClick += MaterialTypeItemClick;
            materialTypeList = materialService.GetAllMaterialType();
            TreeDataBind(materialTypeList);
            labelControl8.Text = materialService.GetAllMaterial().Count.ToString();
            if (PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Nodes.Count > 0)
            {
                var id = PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Nodes[0].GetValue(Type_Id);
                var materialList = materialService.GetMaterialByTypeId(Convert.ToInt32(id));
                RefreshDataBind(materialList);
            }
        }
        private void MaterialTypeItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "MaterialType_Add_Parent_BarButtonItem":
                    object parent_id;
                    if (PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode == null) parent_id = 0;
                    else
                        parent_id = PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode.GetValue("Parent_Id");
                    TreeAddParnetORChild(Convert.ToInt32(parent_id));
                    break;
                case "MaterialType_Add_Child_BarButtonItem":
                    if (PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode == null) return;
                    var id = PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode.GetValue("Id");
                    TreeAddParnetORChild(Convert.ToInt32(id));
                    break;
                case "MaterialType_Delete_BarButtonItem":
                    break;
                case "MaterialType_Modify_BarButtonItem":
                    break;
                case "btnMaterialAdd":
                    AddMaterialInfor addMaterial = new AddMaterialInfor();
                    addMaterial.Show();
                    break;
                case "btnAnalogyMaterialAdd":
                    MaterBasePro = (MaterialBaseProperty)PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetFocusedRow();
                    AddMaterialInfor analogyAdd = new AddMaterialInfor();
                    analogyAdd.Tag = "AnalogyAdd";
                    analogyAdd.MaterBase = MaterBasePro;
                    analogyAdd.ShowDialog();
                    break;
            }
        }
        private void MaterialItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "MaterialMessage_DirectAdd_BarButtonItem":
                    AddMaterialInfor addMaterial = new AddMaterialInfor();
                    addMaterial.Show();
                    break;
                case "MaterialMessage_AnalogyAdd_BarButtonItem":
                    MaterBasePro = (MaterialBaseProperty)PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetFocusedRow();
                    AddMaterialInfor analogyAdd = new AddMaterialInfor();
                    analogyAdd.Tag = "AnalogyAdd";
                    analogyAdd.MaterBase = MaterBasePro;
                    analogyAdd.ShowDialog();
                    break;
                case "MaterialMessage_Delete_BarButtonItem":
                    DeleteMaterialMessage();
                    break;
                case "MaterialMessage_Modify_BarButtonItem":
                    var id = PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode.GetValue(Type_Id);
                    var material = materialService.GetAllMaterial().Find(m => m.Id == Convert.ToInt32(id));
                    //MaterBasePro = (MaterialBaseProperty)PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetFocusedRow();
                    AddMaterialInfor modifyMaterial = new AddMaterialInfor();
                    modifyMaterial.material = material;
                    modifyMaterial.Tag = "Modify";
                    modifyMaterial.ShowDialog();
                    break;
            }
        }
        private void PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            var treeList = sender as TreeList;
            var hitInfo = treeList.CalcHitInfo(e.Location);
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None))
            {
                if (hitInfo.Node == null)
                {
                    btnAnalogyMaterialAdd.Enabled = false;
                    btnMaterialAdd.Enabled = false;
                    MaterialType_Add_Child_BarButtonItem.Enabled = false;
                    MaterialType_Delete_BarButtonItem.Enabled = false;
                    MaterialType_Modify_BarButtonItem.Enabled = false;
                }
                else
                {
                    var is_last = hitInfo.Node.GetValue("Is_Last");
                    btnAnalogyMaterialAdd.Enabled = is_last.Equals("是") ? true : false;
                    btnMaterialAdd.Enabled = is_last.Equals("是") ? true : false;
                    MaterialType_Add_Child_BarButtonItem.Enabled = is_last.Equals("是") ? false : true;
                    MaterialType_Delete_BarButtonItem.Enabled = true;
                    MaterialType_Modify_BarButtonItem.Enabled = true;
                    treeList.SetFocusedNode(hitInfo.Node);
                }
                popupMenu2.ShowPopup(Control.MousePosition);
            }
            else
            {
                if (hitInfo.Node == null) return;
                var id = hitInfo.Node.GetValue(Type_Id);
                var materialList = materialService.GetMaterialByTypeId(Convert.ToInt32(id));
                RefreshDataBind(materialList);
            }
        }
        private void PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None))
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
        private void PartsMange_MaterialBankManage_MaterialBankManage_QueryMaterialManage_SimpleButton_Click(object sender, EventArgs e)
        {
            string cn_name = PartsMange_MaterialBankManage_MaterialBankManage_TypeQueryMaterialManage_TextEdit.Tag.ToString();
            string type = PartsMange_MaterialBankManage_MaterialBankManage_TypeQueryMaterialManage2_ComboBoxEdit.Tag.ToString();
            string status = PartsMange_MaterialBankManage_MaterialBankManage_TypeQueryMaterialManage_ComboBoxEdit.Tag.ToString();

            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl.DataSource = materialService.GetAllMaterial();
            //WcfServiceLocator.Create<IMaterialBankManage>().QueryMaterial();
        }
        public void DeleteMaterialMessage()
        {
            var id = PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetFocusedRowCellValue("id");
            //WcfServiceLocator.Create<IMaterialBankManage>().DeleteMaterialMessage(Convert.ToInt32(id));
        }
        private void TreeDataBind(List<Material_Type> typeList)
        {
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.DataSource = null;
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.DataSource = typeList;
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.KeyFieldName = "Id";
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.ParentFieldName = "Parent_Id";
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.ExpandAll();
        }
        private void TreeAddParnetORChild(int parent_id)
        {
            var type = new Material_Type();
            type.Id = materialTypeList[materialTypeList.Count - 1].Id;
            type.Parent_Id = Convert.ToInt32(parent_id);
            var addType = new AddType();
            addType.type = type;
            addType.ShowDialog();
            if (addType.DialogResult == DialogResult.OK)
            {
                materialTypeList.Add(addType.type);
                TreeDataBind(materialTypeList);
            }
        }
        private void RefreshDataBind(List<Material> materialList)
        {
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl.DataSource = materialList;
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl.RefreshDataSource();
        }
    }
}