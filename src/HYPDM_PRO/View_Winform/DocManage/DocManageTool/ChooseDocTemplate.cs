using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;

namespace View_Winform.DocManage.DocManageTool
{
    public partial class ChooseDocTemplate : DevExpress.XtraEditors.XtraForm
    {
        private List<doc_template> pList = new List<doc_template>();

        public String modelId
        {
            get;
            set;
        }

        public ChooseDocTemplate()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void ChooseDocTemplate_Load(object sender, EventArgs e)
        {
            // 自动加载数据
            doc_template DOC = new doc_template();
            DOC.id = 1;
            DOC.name = "设计文档";
            DOC.parent_id = -1;
            DOC.file_type = "Files";

            pList.Add(DOC);
            doc_template DOC1 = new doc_template();
            DOC1.id = 2;
            DOC1.name = "办公文档";
            DOC1.parent_id = -1;
            DOC1.file_type = "Files";
            pList.Add(DOC1);

            doc_template DOC2 = new doc_template();
            DOC2.id = 3;
            DOC2.name = "需求文档模板";
            DOC2.parent_id = 1;
            DOC2.parent_name = "设计文档";
            DOC2.breadth = "A4";
            DOC2.create_date = DateTime.Parse("2013-01-01");
            DOC2.create_user_name = "李俊";
            DOC2.create_user_id = 1;
            DOC2.modify_date = DateTime.Parse("2014-01-03");
            DOC2.modify_user_name = "张三";
            DOC2.modify_user_id = 2;
            DOC2.modify_count = "2";
            DOC2.file_type = "File";
            pList.Add(DOC2);

            this.treeList2.DataSource = pList;
            this.treeList2.ParentFieldName = "ParentId";
            this.treeList2.KeyFieldName = "Id";
            this.treeList2.OptionsView.ShowColumns = false;

            this.treeList2.RefreshDataSource();
        }

        private void DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add_Click(object sender, EventArgs e)
        {
           
            String mo = this.DocManagement_DocModify_TextEdit_.Text;
            if (String.IsNullOrEmpty(mo))
            {
                MessageBox.Show("请选中模板");
                return;
            }
            modelId = mo;
            //选中模板
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void treeList2_Click(object sender, EventArgs e)
        {
            String id = this.treeList2.FocusedNode.GetValue("id").ToString();
            doc_template s = GetDocTemplate(int.Parse(id));
            if (s != null)
            {
                this.DocManagement_DocModify_TextEdit_.Text = s.name;
            }
            else
            {
                this.DocManagement_DocModify_TextEdit_.Text = "";
            }
            
        }

        private doc_template GetDocTemplate(int id)
        {
            if (pList != null || pList.Count != 0)
            {
                foreach (doc_template t in pList)
                {
                    if (t.id == id && t.file_type == "File")
                    {
                        return t;
                    }
                }
            }
            return null;
        }

        private void treeList2_MouseUp(object sender, MouseEventArgs e)
        {
            String id = this.treeList2.FocusedNode.GetValue("id").ToString();
            doc_template s = GetDocTemplate(int.Parse(id));
            if (s != null)
            {
                this.DocManagement_DocModify_TextEdit_.Text = s.name;
            }
            else
            {
                this.DocManagement_DocModify_TextEdit_.Text = "";
            }
        }

        
    }
}