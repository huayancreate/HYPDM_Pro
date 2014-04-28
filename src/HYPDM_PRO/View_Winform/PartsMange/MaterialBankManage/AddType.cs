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
    public partial class AddType : DevExpress.XtraEditors.XtraForm
    {
        IMaterialBankManage materialService = WcfServiceLocator.Create<IMaterialBankManage>();
        public Material_Type type;
        public AddType()
        {
            InitializeComponent();
        }
        private void AddType_Load(object sender, EventArgs e)
        {
            PartsMange_MaterialBankManage_AddType_ConfirmType_SimpleButton.Click += SaveORUpdateClick;
            DataBind();
        }
        private void SaveORUpdateClick(object sender, EventArgs e)
        {
            type = MaterialType();
            materialService.AddORUpdateType(type);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void DataBind()
        {
            if (type == null) return;
            PartsMange_MaterialBankManage_AddType_MaterialBasicType_TextEdit.Text = type.Name;
            PartsMange_MaterialBankManage_AddType_MaterialBasicIdentification_TextEdit.Text = type.Mark;
            PartsMange_MaterialBankManage_AddType_MaterialBasicType_IsLast_RadioGroup.SelectedIndex = Convert.ToInt32(type.Is_Last);
            PartsMange_MaterialBankManage_AddType_IdentificationLength_ComboBoxEdit.SelectedIndex = Convert.ToInt32(type.Child_Mark_Length);
            PartsMange_MaterialBankManage_AddType_MaterialBasicType_CodeStart_RadioGroup.SelectedIndex = Convert.ToInt32(type.Code_Start);
            PartsMange_MaterialBankManage_AddType_WaterCodeLength_ComboBoxEdit.SelectedIndex = Convert.ToInt32(type.Code_Length);
        }
        private Material_Type MaterialType()
        {
            var index = PartsMange_MaterialBankManage_AddType_MaterialBasicType_IsLast_RadioGroup.SelectedIndex;
            var materialType = new Material_Type
            {
                Id = type.Id + 1,
                Name = PartsMange_MaterialBankManage_AddType_MaterialBasicType_TextEdit.Text,
                Mark = PartsMange_MaterialBankManage_AddType_MaterialBasicIdentification_TextEdit.Text,
                Is_Last = PartsMange_MaterialBankManage_AddType_MaterialBasicType_IsLast_RadioGroup.Properties.Items[index].Description,
                Child_Mark_Length = PartsMange_MaterialBankManage_AddType_IdentificationLength_ComboBoxEdit.SelectedIndex.ToString(),
                Code_Start = PartsMange_MaterialBankManage_AddType_MaterialBasicType_CodeStart_RadioGroup.SelectedIndex.ToString(),
                Code_Length = PartsMange_MaterialBankManage_AddType_WaterCodeLength_ComboBoxEdit.SelectedIndex.ToString(),
                Parent_Id = type.Parent_Id,
                Create_Date = DateTime.Now,
                Create_User_Id = 1
            };
            return materialType;
        }
        private void PartsMange_MaterialBankManage_AddType_CancelType_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartsMange_MaterialBankManage_AddType_MaterialBasicType_IsLast_RadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = PartsMange_MaterialBankManage_AddType_MaterialBasicType_IsLast_RadioGroup.SelectedIndex;
            PartsMange_MaterialBankManage_AddType_MaterialBasicType_CodeStart_RadioGroup.Enabled = index == 0 ? true : false;
            PartsMange_MaterialBankManage_AddType_WaterCodeLength_ComboBoxEdit.Enabled = index == 0 ? true : false;
        }
    }
}