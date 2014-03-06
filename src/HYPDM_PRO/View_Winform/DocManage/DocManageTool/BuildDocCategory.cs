using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.DocManage.DocManageTool
{
    public partial class BuildDocCategory : DevExpress.XtraEditors.XtraForm
    {
        public document_tree docTree { get; set; }
        private int actionType = 0;
        public BuildDocCategory()
        {
            InitializeComponent();
        }

        public BuildDocCategory(document_tree _docTree, int actionType)
        {
            InitializeComponent();
            this.docTree = _docTree;
            this.actionType = actionType;
        }

        private void BuildDocTemplateCategory_Load(object sender, EventArgs e)
        {
            // 初始化数据
            this.txtName.Text = docTree.name;
            this.txtParent.Text = docTree.parent_name;

            this.Text = "新建文档分类";
            if(actionType == 2 )
            {
                this.Text = "修改文档分类";
                // 编辑
                this.txtParent.Enabled = false;
            }
            else if (actionType == 3)
            {
                this.Text = "查看文档分类";
                // 查看
                this.txtName.Enabled = false;
                this.txtParent.Enabled = false;
                this.btnCannel.Text = "关闭";
                this.btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (actionType == 2)
                {
                    this.docTree.name = this.txtName.Text;
                    WcfServiceLocator.Create<IDocManageTool>().addDocumentTree(docTree);
                }
                else
                {
                    this.docTree.name = this.txtName.Text;
                    docTree = WcfServiceLocator.Create<IDocManageTool>().updateDocumentTree(docTree);
                    this.docTree.id = 7;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // 保存新建的分类
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            // 取消事件
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}