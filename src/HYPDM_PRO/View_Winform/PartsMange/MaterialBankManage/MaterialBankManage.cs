using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
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
        private List<Material_Type> materialTypeList = new List<Material_Type>();
        public Material material { get; set; }
        private List<Material> materialList = new List<Material>();
        public MaterialBankManage()
        {
            InitializeComponent();
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView, true);
        }
        private void MaterialBankManage_Load(object sender, EventArgs e)
        {
            simpleButton1.Visible |= this.Tag == "choose";
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            barManager1.ItemClick += MaterialItemClick;
            barManager2.ItemClick += MaterialTypeItemClick;
            simpleButton1.Click += ChooseMaterialClick;
            materialTypeList = materialService.GetAllMaterialType();
            TreeDataBind(materialTypeList);
            labelControl8.Text = materialService.GetAllMaterial().Count.ToString();
            if (PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Nodes.Count > 0)
            {
                var id = PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Nodes[0].GetValue(Type_Id);
                materialList = materialService.GetMaterialByTypeId(Convert.ToInt32(id));
                RefreshDataBind(materialList);
            }
        }
        private void MaterialTypeItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "MaterialType_Add_Parent_BarButtonItem":
                    TreeAddParnetORChild(Convert.ToInt32(parent_Id));
                    break;
                case "MaterialType_Add_Child_BarButtonItem":
                    TreeAddParnetORChild(Convert.ToInt32(material_Type_Id));
                    break;
                case "MaterialType_Delete_BarButtonItem":
                    DeleteMaterialType();
                    break;
                case "MaterialType_Modify_BarButtonItem":
                    var materialType = materialTypeList.Find(t => t.Id == Convert.ToInt32(material_Type_Id));
                    var modifyType = new AddType();
                    modifyType.Text = "修改物料类型";
                    modifyType.type = materialType;
                    modifyType.ShowDialog();
                    if (modifyType.DialogResult == DialogResult.OK)
                    {
                        materialTypeList.Remove(materialType);
                        materialTypeList.Add(modifyType.type);
                        TreeDataBind(materialTypeList);
                    }
                    break;
                case "btnMaterialAdd":
                    var addMaterial = new AddMaterialInfor();
                    var material = new Material();
                    material.Material_Type_Id = Convert.ToInt32(material_Type_Id);
                    addMaterial.material = material;
                    addMaterial.ShowDialog();
                    break;
            }
        }
        private void MaterialItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "MaterialMessage_DirectAdd_BarButtonItem":
                    var addMaterial = new AddMaterialInfor();
                    var material = new Material();
                    material.Material_Type_Id = Convert.ToInt32(material_Type_Id);
                    addMaterial.material = material;
                    addMaterial.Show();
                    break;
                case "MaterialMessage_AnalogyAdd_BarButtonItem":
                    material = materialService.GetAllMaterial().Find(m => m.Id == Convert.ToInt32(material_Id));
                    var analogyAdd = new AddMaterialInfor();
                    analogyAdd.Tag = "AnalogyAdd";
                    analogyAdd.material = material;
                    analogyAdd.ShowDialog();
                    break;
                case "MaterialMessage_Delete_BarButtonItem":
                    DeleteMaterial();
                    break;
                case "MaterialMessage_Modify_BarButtonItem":
                    material = materialService.GetAllMaterial().Find(m => m.Id == Convert.ToInt32(material_Id));
                    var modifyMaterial = new AddMaterialInfor();
                    modifyMaterial.material = material;
                    modifyMaterial.Tag = "Modify";
                    modifyMaterial.Text = "修改物料信息";
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
                    if (materialTypeList.Count > 0) return;
                    btnAnalogyMaterialAdd.Enabled = false;
                    btnMaterialAdd.Enabled = false;
                    MaterialType_Add_Child_BarButtonItem.Enabled = false;
                    MaterialType_Delete_BarButtonItem.Enabled = false;
                    MaterialType_Modify_BarButtonItem.Enabled = false;
                }
                else
                {
                    var is_last = hitInfo.Node.GetValue("Is_Last");
                    btnAnalogyMaterialAdd.Enabled = is_last.Equals("1") ? true : false;
                    btnMaterialAdd.Enabled = is_last.Equals("1") ? true : false;
                    MaterialType_Add_Child_BarButtonItem.Enabled = is_last.Equals("1") ? false : true;
                    MaterialType_Delete_BarButtonItem.Enabled = true;
                    MaterialType_Modify_BarButtonItem.Enabled = true;
                    treeList.SetFocusedNode(hitInfo.Node);
                }
                popupMenu2.ShowPopup(Control.MousePosition);
            }
            else
            {
                if (hitInfo.Node == null)
                    return;
                var id = hitInfo.Node.GetValue(Type_Id);
                materialList = materialService.GetMaterialByTypeId(Convert.ToInt32(id));
                RefreshDataBind(materialList);
            }
        }
        private void PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None))
            {
                if (materialList.Count == 0)
                {
                    MaterialMessage_Delete_BarButtonItem.Enabled = false;
                    MaterialMessage_AnalogyAdd_BarButtonItem.Enabled = false;
                    MaterialMessage_Modify_BarButtonItem.Enabled = false;
                }
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
        private void TreeDataBind(List<Material_Type> typeList)
        {
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.DataSource = null;
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.DataSource = typeList;
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.KeyFieldName = "Id";
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.ParentFieldName = "Parent_Id";
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.RefreshDataSource();
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.ExpandAll();
        }
        private void TreeAddParnetORChild(int parent_id)
        {
            var type = new Material_Type();
            if (materialTypeList.Count > 0)
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
        private void DeleteMaterialType()
        {
            materialService.DeleteMaterialType(Convert.ToInt32(material_Type_Id));
            var typeList = materialService.GetAllMaterialType();
            TreeDataBind(typeList);
        }
        private void DeleteMaterial()
        {
            materialService.DeleteMaterialType(Convert.ToInt32(material_Id));
            materialList = materialService.GetAllMaterial();
            RefreshDataBind(materialList);
        }
        private object parent_Id
        {
            get
            {
                if (PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode == null)
                    return null;
                return PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode.GetValue(Parent_Id);
            }
        }
        private object material_Type_Id
        {
            get
            {
                if (PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode == null)
                    return null;
                return PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.FocusedNode.GetValue(Type_Id);
            }
        }
        private object material_Id
        {
            get
            {
                return PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetFocusedRowCellValue("Id");
            }
        }
        /// <summary>
        /// 选择材料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseMaterialClick(object sender, EventArgs e)
        {
            material = materialList.Find(m => m.Id == Convert.ToInt32(material_Id));
            this.DialogResult = DialogResult.OK;
        }
    }
}