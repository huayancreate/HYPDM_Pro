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

namespace View_Winform.PartsMange
{
    public partial class ChooseMaterialType : DevExpress.XtraEditors.XtraForm
    {
        private IMaterialBankManage materialService = WcfServiceLocator.Create<IMaterialBankManage>();
        public List<Material_Type> materialTypeList = new List<Material_Type>();
        public bool is_extend { get; set; }
        public ChooseMaterialType()
        {
            InitializeComponent();
            PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList = BaseControls.BaseTreeListControl.
                BaseTreeListControlSetting(PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList, false);
        }
        private void ChooseMaterialType_Load(object sender, EventArgs e)
        {
            PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.ClearNodes();
            PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.KeyFieldName = "Id";
            PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.ParentFieldName = "Parent_Id";
            PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.DataSource = materialService.GetAllMaterialType();

        }
        private void PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void MaterialType_Add_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton_Click(object sender, EventArgs e)
        {
            var materialType = new Material_Type();
            var focusNode = PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.FocusedNode;
            materialType.Id = Convert.ToInt32(focusNode.GetValue(MaterialType_Id));
            materialType.Mark = focusNode.GetValue(MaterialType_Mark).ToString();
            materialType.Name = focusNode.GetValue(MaterialType_Name).ToString();
            materialTypeList.Add(materialType);
            if (is_extend)
            {
                GetChildByParentId(materialType.Id, ref materialTypeList);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void GetChildByParentId(int id, ref List<Material_Type> materialTypeList)
        {
            var typeList = materialService.GetAllMaterialType().FindAll(s => s.Parent_Id == id);
            foreach (var item in typeList)
            {
                materialTypeList.Add(item);
                GetChildByParentId(item.Id, ref materialTypeList);
            }

        }
    }
}