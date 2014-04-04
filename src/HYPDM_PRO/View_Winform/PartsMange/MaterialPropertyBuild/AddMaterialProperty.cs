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
    public partial class AddMaterialProperty : DevExpress.XtraEditors.XtraForm
    {
        public Material Mate;
        public MaterialType Mt;
        public MaterialBaseProperty MaterBase;
        public AddMaterialProperty()
        {
            InitializeComponent();
        }

        private void AddMaterialProperty_Load(object sender, EventArgs e)
        {
            IList<MaterialBaseProperty> M = new BindingList<MaterialBaseProperty>();
            M = WcfServiceLocator.Create<IAddMaterialProperty>().Mat();
            PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridControl.DataSource = M;
            string type = PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataType_ComboBoxEdit.DataBindings.ToString();

            IList<MaterialType> Ma = new BindingList<MaterialType>();
            Ma = WcfServiceLocator.Create<IAddMaterialProperty>().MT();
            PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridControl.DataSource = Ma; 


            if(this.Tag == "Modify")
            {
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_ChnName_TextEdit.Text = MaterBase.cn_name;
                //PartsMange_MaterialPropertyBuild_AddMaterialProperty_FieldName_TextEdit.Text = MaterBase.name;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataType_ComboBoxEdit.Text = MaterBase.data_type;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataLength_TextEdit.Text = MaterBase.data_length;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_ClassifyInherit_CheckEdit.Text = MaterBase.is_extends;
                WcfServiceLocator.Create<IAddMaterialProperty>().Mat();
            }

            if(this.Tag == "Add")
            {
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_ChnName_TextEdit.Text = MaterBase.cn_name;
                //PartsMange_MaterialPropertyBuild_AddMaterialProperty_FieldName_TextEdit.Text = MaterBase.name;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataType_ComboBoxEdit.Text = MaterBase.data_type;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataLength_TextEdit.Text = MaterBase.data_length;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_DefaultValue_TextEdit.Text = MaterBase.default_value;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_MustEntering_CheckEdit.Text = MaterBase.input_type;
                PartsMange_MaterialPropertyBuild_AddMaterialProperty_ClassifyInherit_CheckEdit.Text = MaterBase.is_extends;
                WcfServiceLocator.Create<IAddMaterialProperty>().Mat();
            }
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
            if(e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_AddMaterialClassify_SimpleButton_Click(object sender, EventArgs e)
        {
            MaterialBaseProperty M = new MaterialBaseProperty();
            M.en_name = PartsMange_MaterialPropertyBuild_AddMaterialProperty_ChnName_TextEdit.Text;
            //M.name = PartsMange_MaterialPropertyBuild_AddMaterialProperty_FieldName_TextEdit.Text;
            M.data_type = PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataType_ComboBoxEdit.Text;
            M.data_length = PartsMange_MaterialPropertyBuild_AddMaterialProperty_DataLength_TextEdit.Text;
            M.default_value = PartsMange_MaterialPropertyBuild_AddMaterialProperty_DefaultValue_TextEdit.Text;
            M.input_type = PartsMange_MaterialPropertyBuild_AddMaterialProperty_MustEntering_CheckEdit.Text;
            M.is_extends = PartsMange_MaterialPropertyBuild_AddMaterialProperty_ClassifyInherit_CheckEdit.Text;
            bool ok = WcfServiceLocator.Create<IAddMaterialProperty>().AddMaterial(M.id);
            MessageBox.Show(ok.ToString());

        }

        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_DeleteMaterialClassify_SimpleButton_Click(object sender, EventArgs e)
        {
            DeleteMaterialType();
        }

        public void DeleteMaterialType() 
        {
            string value = "";
            int id;
            int check = 0;
            for (int i = 0; i < PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridView.RowCount; i++) 
            {
                if(value == "ture")
                {
                id =(int)PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridView.GetRowCellValue(i, "check");
                MessageBox.Show("id=" + id.ToString());
                WcfServiceLocator.Create<IAddMaterialProperty>().DeleteMaterialType(id);
                }
            }
            if(check == 0)
            {
                MessageBox.Show("请选择一条记录！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.None); 
            }
        }

        //右键菜单修改 物料分类
        private void MaterialType_Modify_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Mt =(MaterialType)PartsMange_MaterialPropertyBuild_AddMaterialProperty_MaterialClassify_GridView.GetFocusedRow();
            ChooseMaterialType CM = new ChooseMaterialType();
            CM.Tag = "Modify";
            CM.MT = Mt;
            CM.ShowDialog();
        }

        private void PartsMange_MaterialPropertyBuild_AddMaterialProperty_SelectMaterialClassify_SimpleButton_Click(object sender, EventArgs e)
        {
            ChooseMaterialType CM = new ChooseMaterialType();
            CM.ShowDialog();
        }
    }
}
