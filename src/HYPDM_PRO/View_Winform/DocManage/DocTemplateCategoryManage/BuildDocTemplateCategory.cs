using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.DocManage.DocTemplateCategoryManage
{
    public partial class BuildDocTemplateCategory : DevExpress.XtraEditors.XtraForm
    {
        #region 自定义变量

        // 传递的文档模板文件夹
        public doc_template_tree docTemplateTree
        {
            get;
            set;
        }
        // 操作类型
        private int actionType = 0;
        public BuildDocTemplateCategory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="docTemplateTree"></param>
        /// <param name="actionType"></param>
        public BuildDocTemplateCategory(doc_template_tree docTemplateTree, int actionType)
        {
            InitializeComponent();
            this.docTemplateTree = docTemplateTree;
            this.actionType = actionType;
        }
        #endregion 

        #region  自定义加载
        /// <summary>
        /// 自定义加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildDocTemplateCategory_Load(object sender, EventArgs e)
        {
            // 初始化数据
            this.txtName.Text = docTemplateTree.name;
            this.txtParent.Text = docTemplateTree.parent_name;
            if(actionType == 2 )
            {
                // 编辑
                this.txtParent.Enabled = false;
            }
            else if (actionType == 3)
            {
                // 查看
                this.txtName.Enabled = false;
                this.txtParent.Enabled = false;
                this.btnCannel.Text = "关闭";
                this.btnSave.Enabled = false;
            }
        }
        #endregion 

        #region 点击事件
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            docTemplateTree.name = this.txtName.Text;
            if (actionType == 1)
            {
                docTemplateTree = WcfServiceLocator.Create<IDocTemplateCategoryManage>().insertDocumentTemplateTree(docTemplateTree);
                // 新建

            }
            else if (actionType == 2)
            {
                docTemplateTree = WcfServiceLocator.Create<IDocTemplateCategoryManage>().updateDocumentTemplateTree(docTemplateTree);
                // 修改

            }
            // 保存新建的分类
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCannel_Click(object sender, EventArgs e)
        {
            // 取消事件
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion  
    }
}