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
using System.Collections;
using System.Reflection;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class AddMaterialProperty : DevExpress.XtraEditors.XtraForm
    {
        IMaterialBankManage materialService = WcfServiceLocator.Create<IMaterialBankManage>();
        IMaterialPropertyBuild propertyService = WcfServiceLocator.Create<IMaterialPropertyBuild>();
        public Material_Type materialType;
        public MaterialAttachedProperty attachedProperty { get; set; }
        public MaterialBaseProperty baseProperty { get; set; }
        List<Material_Type> materialTypeList = new List<Material_Type>();
        DataTable dtCboValue = new DataTable();
        List<Material_ComboBox_Value> comboBoxValueList = new List<Material_ComboBox_Value>();
        public AddMaterialProperty()
        {
            InitializeComponent();
        }
        private void AddMaterialProperty_Load(object sender, EventArgs e)
        {
            radioGroup1.SelectedIndexChanged += RadioSelectChange;
            simpleButton4.Click += new EventHandler(AddItem);
            simpleButton3.Click += new EventHandler(DelItem);
            simpleButton2.Click += new EventHandler(SubmitItem);
            if (this.Tag == "Modify")
            {
                materialTypeList = materialService.GetAllMaterialType();
                MaterialTypeListBind(materialTypeList);
                if (baseProperty == null) return;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_ChnName_TextEdit.Text = baseProperty.cn_name;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_FieldName_TextEdit.Text = baseProperty.en_name;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataType_ComboBoxEdit.SelectedIndex = Convert.ToInt32(baseProperty.data_type);
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataLength_TextEdit.Text = baseProperty.data_length;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_ClassifyInherit_CheckEdit.Checked = Convert.ToBoolean(baseProperty.is_extends);
                radioGroup1.SelectedIndex = Convert.ToInt32(baseProperty.input_type);
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_MustEntering_CheckEdit.Checked = Convert.ToBoolean(baseProperty.required);
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DefaultValue_TextEdit.Text = baseProperty.default_value;
                var dt = propertyService.GetListToDataTable(baseProperty.id);
                ComboBoxValueListBind(dt);
            }
        }
        private void SubmitItem(object sender, EventArgs e)
        {
            for (int i = 0; i < dtCboValue.Rows.Count; i++)
            {
                var val = dtCboValue.Rows[i][0];
                var obj = new Material_ComboBox_Value();
                obj.Id = i;
                obj.Value = val.ToString();
                obj.Create_Date = DateTime.Now;
                obj.Create_User_Id = 1;
                obj.Is_Delete = "0";
                obj.Extend_Id = 1;
                comboBoxValueList.Add(obj);
                propertyService.AddORUpdateComboBoxValue(obj);
            }
        }
        private void DelItem(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }
        private void AddItem(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }
        private void RadioSelectChange(object sender, EventArgs e)
        {
            groupControl1.Visible = radioGroup1.SelectedIndex != 0;
        }
        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_CancelMaterialClassify_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }
        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_AddMaterialClassify_SimpleButton_Click(object sender, EventArgs e)
        {
            #region 1.保存基本属性
            attachedProperty = new MaterialAttachedProperty();
            attachedProperty.cn_name = PartsMange_MaterialPropertyBuild_AddMaterialProperty_ChnName_TextEdit.Text;
            attachedProperty.en_name = PartsMange_MaterialPropertyBuild_AddMaterialProperty_FieldName_TextEdit.Text;
            attachedProperty.input_type = radioGroup1.SelectedIndex.ToString();
            attachedProperty.required = PartsMange_MaterialPropertyBuild_AddMaterialProperty_MustEntering_CheckEdit.CheckState.ToString();
            attachedProperty.data_type = PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataType_ComboBoxEdit.SelectedIndex.ToString();
            attachedProperty.default_value = PartsMange_MaterialPropertyBuild_AddMaterialProperty_DefaultValue_TextEdit.Text;
            attachedProperty.data_length = PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataLength_TextEdit.Text;
            attachedProperty.is_extends = PartsMange_MaterialPropertyBuild_AddMaterialProperty_ClassifyInherit_CheckEdit.Checked.ToString();
            #endregion
            #region 2.保存物料分类与属性关系
            foreach (var type in materialTypeList)
            {
                //save
            }
            #endregion
            #region 3.保存下拉框值
            foreach (var c in comboBoxValueList)
            {
                //save
            }
            #endregion
        }
        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_DeleteMaterialClassify_SimpleButton_Click(object sender, EventArgs e)
        {
            DeleteMaterialType();
        }
        public void DeleteMaterialType()
        {
            var id = PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridView.GetFocusedRowCellValue("Id");
            MessageBox.Show("当前删除的数据为:" + id);
        }
        //右键菜单修改 物料分类
        private void MaterialType_Modify_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            materialType = (Material_Type)PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridView.GetFocusedRow();
            ChooseMaterialType CM = new ChooseMaterialType();
            CM.Tag = "Modify";
            CM.ShowDialog();
        }
        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_SelectMaterialClassify_SimpleButton_Click(object sender, EventArgs e)
        {
            var chooseMaterialType = new ChooseMaterialType();
            chooseMaterialType.is_extend = PartsMange_MaterialPropertyBuild_AddMaterialProperty_ClassifyInherit_CheckEdit.Checked;
            chooseMaterialType.ShowDialog();
            if (chooseMaterialType.DialogResult == DialogResult.OK)
            {
                foreach (var item in chooseMaterialType.materialTypeList)
                {
                    var t = materialTypeList.Find(type => type.Id == item.Id);
                    if (t == null)
                        materialTypeList.Add(item);
                }
                MaterialTypeListBind(materialTypeList);
            }
        }
        private void MaterialTypeListBind(List<Material_Type> typeList)
        {
            PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridControl.DataSource = typeList;
            PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridControl.RefreshDataSource();
            PartsMange_MaterialPropertyBuild_AddMaterialProperty_DeleteMaterialClassify_SimpleButton.Enabled =
                    typeList.Count > 0 ? true : false;

        }
        private void ComboBoxValueListBind(DataTable dt)
        {
            gridControl1.DataSource = dt;
            gridControl1.RefreshDataSource();
        }
    }
}
