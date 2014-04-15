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
    public partial class MaterialReviewRuleManage : DevExpress.XtraEditors.XtraForm
    {
        public RepeatRule Rt;
        public MaterialReviewRuleManage()
        {
            InitializeComponent();
        }

        private void MaterialReviewRuleManage_Load(object sender, EventArgs e)
        {
            IList<RepeatRule> r = new BindingList<RepeatRule>();

            r = WcfServiceLocator.Create<IMaterialReviewRuleManage>().rep();

            PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridControl.DataSource = r;
        }

        private void PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_Add_SimpleButton_Click(object sender, EventArgs e)
        {
                AddReviewRule AR = new AddReviewRule();
                AR.Show();
        }

        private void PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_Modify_SimpleButton_Click(object sender, EventArgs e)
        {
            Rt = (RepeatRule)PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridView.GetFocusedRow();
            AddReviewRule AR = new AddReviewRule();
            AR.Tag = "Modify";
            AR.ModifyRule = Rt;
            AR.ShowDialog();
        }

        private void PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_Look_SimpleButton_Click(object sender, EventArgs e)
        {
            Rt = (RepeatRule)PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridView.GetFocusedRow();
            AddReviewRule AR = new AddReviewRule();
            AR.Tag = "look";
            AR.LookRule = Rt;
            AR.ShowDialog();
        }

        private void PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_Query_SimpleButton_Click(object sender, EventArgs e)
        {
            string name = PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_RuleName_TextEdit.Tag.ToString();
            //string is_strict = PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_Creater_ButtonEdit.Tag.ToString();
            string remark = PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_RuleScope_ButtonEdit.Tag.ToString();
            string is_strict = PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_ReviewProperty_ButtonEdit.Tag.ToString();
            PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridControl.DataSource = 
                WcfServiceLocator.Create<IMaterialReviewRuleManage>().QueryMaterialReviewRule(name, is_strict,remark);
        }

        private void PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_Delete_SimpleButton_Click(object sender, EventArgs e)
        {
            DeleteMaterialReviewRule();
        }

        public void DeleteMaterialReviewRule()
        {
            string value = "";
            int id;
            int check = 0;
            for (int i = 0; i < PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridView.RowCount; i++)
            {
                value = PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridView.GetRowCellValue(i, "check").ToString();
                if(value == "Ture")
                {
                    check++;
                    id = (int)PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridView.GetRowCellValue(i, "id");
                    MessageBox.Show("id=" + id.ToString());
                    WcfServiceLocator.Create<IMaterialReviewRuleManage>().DeleteMaterialReviewRule(id);
                }
            }
         }

        private void barButtonItem_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddReviewRule AR = new AddReviewRule();
            AR.Tag = "Add";
            AR.ShowDialog();
        }

        private void barButtonItem_Modify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Rt = (RepeatRule)PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridView.GetFocusedRow();
            AddReviewRule AR = new AddReviewRule();
            AR.Tag = "Modify";
            AR.ModifyRule = Rt;
            AR.ShowDialog();
        }

        private void barButtonItem_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteMaterialReviewRule();
        }

        private void PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_DuplicateChecking_SimpleButton_Click(object sender, EventArgs e)
        {
            CheckResult CR = new CheckResult();
            CR.ShowDialog();
        }

        private void PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None)) 
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            } 
        }

        private void BarButtonItem_Look_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Rt = (RepeatRule)PartsMange_MaterialReviewRuleManage_MaterialReviewRuleManage_QueryValue_GridView.GetFocusedRow();
            AddReviewRule AR = new AddReviewRule();
            AR.Tag = "look";
            AR.LookRule = Rt;
            AR.ShowDialog();
        }
    }
}