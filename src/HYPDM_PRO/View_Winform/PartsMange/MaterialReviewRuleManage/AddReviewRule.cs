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
using System.IO;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class AddReviewRule : DevExpress.XtraEditors.XtraForm
    {
        public RepeatRule ModifyRule;
        public RepeatRule LookRule;
        public AddReviewRule()
        {
            InitializeComponent();
        }

        private void AddReviewRule_Load(object sender, EventArgs e)
        {
            if(this.Tag == "Modify")
            {
                PartsMange_MaterialReviewRuleManage_AddReviewRule_RuleName_TextEdit.Text = ModifyRule.name;
                PartsMange_MaterialReviewRuleManage_AddReviewRule_Remark_ListBoxControl.Tag = ModifyRule.remark;
                PartsMange_MaterialReviewRuleManage_AddReviewRule_SeleteReviewProperty_GridView.Tag = ModifyRule.is_strict;
            }
            if (this.Tag == "look") 
            {
                PartsMange_MaterialReviewRuleManage_AddReviewRule_RuleName_TextEdit.Text = LookRule.name;
                //PartsMange_MaterialReviewRuleManage_AddReviewRule_Remark_ListBoxControl.Tag = LookRule.remark;
                PartsMange_MaterialReviewRuleManage_AddReviewRule_SeleteReviewProperty_GridView.Tag = LookRule.is_strict;
                PartsMange_MaterialReviewRuleManage_AddReviewRule_Remark_ListBoxControl.DataSource = this.Data;
                PartsMange_MaterialReviewRuleManage_AddReviewRule_Remark_ListBoxControl.DisplayMember = "name";
                PartsMange_MaterialReviewRuleManage_AddReviewRule_Remark_ListBoxControl.ValueMember = "name";
            }
        }

        private void PartsMange_MaterialReviewRuleManage_AddReviewRule_Save_SimpleButton_Click(object sender, EventArgs e)
        {
            //SaveFileDialog s = new SaveFileDialog();
            //s.Filter = "";
            //if(s.ShowDialog() == DialogResult.OK)
            //{
            //    FileStream fs = new FileStream(s.FileName, FileMode.Create);
            //    byte[] b = {1};
            //    fs.Write(b,0,b.Length);
            //    fs.Close();
            //    fs.Dispose();
            //} //另存为


            MessageBox.Show("保存成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();

        }

        private void PartsMange_MaterialReviewRuleManage_AddReviewRule_Cancel_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Close();
            }
        }

        private void PartsMange_MaterialReviewRuleManage_AddReviewRule_Remark_ListBoxControl_DragDrop(object sender, DragEventArgs e)
        {
            //ShowItemValues(PartsMange_MaterialReviewRuleManage_AddReviewRule_Remark_ListBoxControl);
        }

        public DataTable Data 
        {
            get 
            {
                DataTable D = new DataTable();
                D.Columns.Add("name",typeof(string));
                D.Columns.Add("remark",typeof(string));
                D.Columns.Add("is_strict",typeof(string));
                D.Rows.Add(new object[]{"天下无双","1"});
                D.Rows.Add(new object[]{ "平荡三军", "2"});
                D.AcceptChanges();
                 
                return D;
            }
        }

        private void PartsMange_MaterialReviewRuleManage_AddReviewRule_SeleteReviewProperty_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void PartsMange_MaterialReviewRuleManage_AddReviewRule_SeleteRuleScope_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                popupMenu2.ShowPopup(Control.MousePosition);
            }
        }

        private void SeleteReviewProperty_Delete_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteReviewProperty();
        }

        public void DeleteReviewProperty() 
        {
            string value = "";
            int id;
            int Check = 0;
            for (int i = 0; i < PartsMange_MaterialReviewRuleManage_AddReviewRule_SeleteReviewProperty_GridView.RowCount; i++) 
            {
                value = PartsMange_MaterialReviewRuleManage_AddReviewRule_SeleteReviewProperty_GridView.GetRowCellValue(i, "Check").ToString();
                if(value == "true")
                {
                    Check++;
                    id = (int)PartsMange_MaterialReviewRuleManage_AddReviewRule_SeleteReviewProperty_GridView.GetRowCellValue(i, "id");
                    MessageBox.Show("id=" + id.ToString());
                    WcfServiceLocator.Create<IAddReviewRule>().DeleteReviewProperty(id);
                }
            }
        }

      /* private void ShowItemValues(DevExpress.XtraEditors.ListBoxControl checkedListBoxControl)
       {
          StringBuilder sb = new StringBuilder();
          foreach (object item in checkedListBoxControl.Items)
          {
              DataRowView rv = item as DataRowView;
              sb.AppendLine(rv.Row["ColorCode"].ToString());
          }
        }*/
    }
}