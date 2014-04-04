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
    public partial class MaterialBankManage : DevExpress.XtraEditors.XtraForm
    {
        public Material Mod;
        public MaterialBaseProperty MaterBasePro;
        public MaterialBankManage()
        {
            InitializeComponent();
        }

        private void MaterialBankManage_Load(object sender, EventArgs e)
        {
            IList<MaterialBaseProperty> B = new BindingList<MaterialBaseProperty>();
            B = WcfServiceLocator.Create<IMaterialBankManage>().MB();
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl.DataSource = B;
        }

        private void PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            if((e.Button == MouseButtons.Right)&&(ModifierKeys == Keys.None))
            {
                popupMenu2.ShowPopup(Control.MousePosition);
            }
        }

        private void PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None))
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void materialMessage_DirectAdd_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterialInfor AM = new AddMaterialInfor();
            AM.Show();
        }

        private void MaterialMessage_AnalogyAdd_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaterBasePro = (MaterialBaseProperty)PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetFocusedRow();
            AddMaterialInfor AM = new AddMaterialInfor();
            AM.Tag = "AnalogyAdd";
            AM.MaterBase = MaterBasePro;
            AM.ShowDialog();
        }

        private void MaterialMessage_Modify_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterialInfor AM = new AddMaterialInfor();
            AM.Show();
        }

        private void MaterialType_Add_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddType AT = new AddType();
            AT.Show();
        }

        private void MatrialType_Modify_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddType AT = new AddType();
            AT.Show();
        }

        private void PartsMange_MaterialBankManage_MaterialBankManage_QueryMaterialManage_SimpleButton_Click(object sender, EventArgs e)
        {
            string cn_name = PartsMange_MaterialBankManage_MaterialBankManage_TypeQueryMaterialManage_TextEdit.Tag.ToString();
            string type = PartsMange_MaterialBankManage_MaterialBankManage_TypeQueryMaterialManage2_ComboBoxEdit.Tag.ToString();
            string status = PartsMange_MaterialBankManage_MaterialBankManage_TypeQueryMaterialManage_ComboBoxEdit.Tag.ToString();

            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridControl.DataSource = 
                WcfServiceLocator.Create<IMaterialBankManage>().QueryMaterial();
        }

        private void MaterialMessage_Delete_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteMaterialMessage();
        }

        public void DeleteMaterialMessage() 
        {
            string value = "";
            int id;
            int check = 0;
            for (int i = 0; i < PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.RowCount; i++)
            {
                value = PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetRowCellValue(i, "").ToString();
                if(value == "true")
                {
                    check++;
                    id =(int)PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetRowCellValue(i, "id");
                    MessageBox.Show("id=" + id.ToString());
                    WcfServiceLocator.Create<IMaterialBankManage>().DeleteMaterialMessage(id);
                }
                if(check == null)
                {
                    MessageBox.Show("请选择需要删除的记录！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

            }
        }

        private void MaterialMessage_Modify_BarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaterBasePro = (MaterialBaseProperty)PartsMange_MaterialBankManage_MaterialBankManage_MaterialManageList_GridView.GetFocusedRow();
            AddMaterialInfor AI = new AddMaterialInfor();
            AI.Tag = "Modify";
            AI.MaterBase = MaterBasePro;
            AI.ShowDialog();
        }

       

        

        
    }
}