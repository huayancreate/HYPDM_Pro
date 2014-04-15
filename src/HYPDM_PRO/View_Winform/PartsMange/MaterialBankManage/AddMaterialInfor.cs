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
    public partial class AddMaterialInfor : DevExpress.XtraEditors.XtraForm
    {
        public MaterialBaseProperty MaterBase;
        public AddMaterialInfor()
        {
            InitializeComponent();
        }

        private void PartsMange_MaterialBankManage_AddMaterialInfor_CancelMaterialMessage_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Close();
            }
        }

        private void AddMaterialInfor_Load(object sender, EventArgs e)
        {
            if(this.Tag == "Modify")
            {
                PartsMange_MaterialBankManage_AddMaterialInfor_PartNumber_ButtonEdit.Text = MaterBase.number.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_PartName_TextEdit.Text = MaterBase.en_name;
                PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.Text = MaterBase.material_property_type_id.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.Text = MaterBase.variety;
                PartsMange_MaterialBankManage_AddMaterialInfor_Weight_TextEdit.Text = MaterBase.weight;
                PartsMange_MaterialBankManage_AddMaterialInfor_Type_TextEdit.Text = MaterBase.type;
                PartsMange_MaterialBankManage_AddMaterialInfor_BelongClassify_ButtonEdit.Text = MaterBase.belong_classify;
                PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text = MaterBase.product_type;
                PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text = MaterBase.original_number.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_PartVersion_TextEdit.Text = MaterBase.version;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text = MaterBase.unit_measure;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasureGroup_TextEdit.Text = MaterBase.unit_measure_group;
                PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text = MaterBase.material;
                PartsMange_MaterialBankManage_AddMaterialInfor_CostPrice_TextEdit.Text = MaterBase.cost_price;
                PartsMange_MaterialBankManage_AddMaterialInfor_Norms_TextEdit.Text = MaterBase.norms;
                PartsMange_MaterialBankManage_AddMaterialInfor_Remark_GroupControl.Text = MaterBase.remark;
            WcfServiceLocator.Create<IAddMaterialInfor>().MaterialMessage(MaterBase.id);
            }

            if (this.Tag == "AnalogyAdd")
            {
                PartsMange_MaterialBankManage_AddMaterialInfor_PartNumber_ButtonEdit.Text = MaterBase.number.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_PartName_TextEdit.Text = MaterBase.en_name;
                PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.Text = MaterBase.material_property_type_id.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.Text = MaterBase.variety;
                PartsMange_MaterialBankManage_AddMaterialInfor_Weight_TextEdit.Text = MaterBase.weight;
                PartsMange_MaterialBankManage_AddMaterialInfor_Type_TextEdit.Text = MaterBase.type;
                PartsMange_MaterialBankManage_AddMaterialInfor_BelongClassify_ButtonEdit.Text = MaterBase.belong_classify;
                PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text = MaterBase.product_type;
                PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text = MaterBase.original_number.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_PartVersion_TextEdit.Text = MaterBase.version;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text = MaterBase.unit_measure;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasureGroup_TextEdit.Text = MaterBase.unit_measure_group;
                PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text = MaterBase.material;
                PartsMange_MaterialBankManage_AddMaterialInfor_CostPrice_TextEdit.Text = MaterBase.cost_price;
                PartsMange_MaterialBankManage_AddMaterialInfor_Norms_TextEdit.Text = MaterBase.norms;
                PartsMange_MaterialBankManage_AddMaterialInfor_Remark_GroupControl.Text = MaterBase.remark;
                WcfServiceLocator.Create<IAddMaterialInfor>().MaterialMessage(MaterBase.id);
            }
        }

        private void PartsMange_MaterialBankManage_AddMaterialInfor_ConfirmMaterialMessage_SimpleButton_Click(object sender, EventArgs e)
        {
            MaterialBaseProperty M = new MaterialBaseProperty();
            //M.number =PartsMange_MaterialBankManage_AddMaterialInfor_PartNumber_ButtonEdit.Text;
            M.en_name = PartsMange_MaterialBankManage_AddMaterialInfor_PartName_TextEdit.Text;
            M.property= PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.Text;
            M.variety = PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.Text;
            M.weight = PartsMange_MaterialBankManage_AddMaterialInfor_Weight_TextEdit.Text;
            M.type = PartsMange_MaterialBankManage_AddMaterialInfor_Type_TextEdit.Text;
            M.belong_classify = PartsMange_MaterialBankManage_AddMaterialInfor_BelongClassify_ButtonEdit.Text;
            M.product_type = PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text;
            //M.original_number = PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text;
            M.version = PartsMange_MaterialBankManage_AddMaterialInfor_PartVersion_TextEdit.Text;
            M.unit_measure = PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text;
            MaterBase.unit_measure_group = PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasureGroup_TextEdit.Text;
            M.material = PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text;
            M.cost_price = PartsMange_MaterialBankManage_AddMaterialInfor_CostPrice_TextEdit.Text;
            M.norms = PartsMange_MaterialBankManage_AddMaterialInfor_Norms_TextEdit.Text;
            bool ok = WcfServiceLocator.Create<IAddMaterialInfor>().SaveMaterial(M.id);
            MessageBox.Show(ok.ToString());


        }


    }
}