using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using System.Threading;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class CheckResult : DevExpress.XtraEditors.XtraForm
    {
        public Material Mat;
        public MaterialBaseProperty MaterbasePro;
        public CheckResult()
        {
            InitializeComponent();
        }

        private void CheckResult_Load(object sender, EventArgs e)
        {
         
            IList<Material> list = new BindingList<Material>();

            list = WcfServiceLocator.Create<ICheckResult>().GetMaterialcsMessage();

            PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.DataSource = list;

        }

        private void PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton_Click(object sender, EventArgs e)
        {
            MaterbasePro =(MaterialBaseProperty)PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridView.GetFocusedValue();
            AddMaterialInfor AM = new AddMaterialInfor();
            AM.Tag = "select";
            //AM.MaterBase = MaterbasePro;
            AM.ShowDialog();
            

        }

        private void PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton_Click(object sender, EventArgs e)
        {

           
            MessageBox.Show("保存成功!", "提示消息", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Close();
            }
        }

        private void PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);  
            }
        }

        private void CheckResult_Add_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterialInfor AM = new AddMaterialInfor();
            AM.ShowDialog();
        }

        private void CheckResult_Modify_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaterbasePro = (MaterialBaseProperty)PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridView.GetFocusedRow();
            AddMaterialInfor AM = new AddMaterialInfor();
            AM.Tag = "Modify";
            //AM.MaterBase = MaterbasePro;
            AM.ShowDialog();
        }
    }
}