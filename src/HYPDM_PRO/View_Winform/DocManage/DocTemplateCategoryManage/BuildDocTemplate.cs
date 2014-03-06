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

namespace View_Winform.DocManage.DocTemplateCategoryManage
{
    public partial class BuildDocTemplate : DevExpress.XtraEditors.XtraForm
    {
        #region  自定变量
        // 传递的文档模板
        public doc_template docTemplate
        {
            get;
            set;
        }
        // 文档的操作
        private int actionType = 1;
        public BuildDocTemplate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="docTemplate"></param>
        /// <param name="actionType"></param>
        public BuildDocTemplate(doc_template docTemplate, int actionType)
        {
            InitializeComponent();
            this.docTemplate = docTemplate;
            this.actionType = actionType;
        }
        #endregion 

        
        #region 加载事件
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildDocTemplate_Load(object sender, EventArgs e)
        {
            this.txtFilePath.Enabled = false;
            //this.txtTemplateId.Enabled = false;
            this.txtTemplateType.Enabled = false;
            this.txtCreateUser.Enabled = false;
            this.txtModifyDate.Enabled = false;
            this.txtModifyCount.Enabled = false;
            this.txtTemplateStatus.Enabled = false;
            if (actionType == 2)
            {
                this.txtTemplateName.Text = docTemplate.name;
                this.txtBreadth.Text = docTemplate.breadth;
                this.txtTemplateId.Text = docTemplate.id.ToString();
                this.txtTemplateType.Text = docTemplate.parent_name;
                this.txtCreateUser.Text = docTemplate.create_user_name;
                this.txtModifyDate.Text = docTemplate.modify_date.ToShortDateString();
                this.txtModifyCount.Text = docTemplate.modify_count;
                this.txtTemplateStatus.Text = docTemplate.is_delete;
                // 修改模板
                this.Text = "修改文档模板";
            }
            else if (actionType == 3)
            {
                // 查看模板
                this.Text = "查看文档模板";
                this.txtTemplateName.Text = docTemplate.name;
                this.txtBreadth.Text = docTemplate.breadth;
                this.txtTemplateId.Text = docTemplate.id.ToString();
                this.txtTemplateType.Text = docTemplate.parent_name;
                this.txtCreateUser.Text = docTemplate.create_user_name;
                this.txtModifyDate.Text = docTemplate.modify_date.ToShortDateString();
                this.txtModifyCount.Text = docTemplate.modify_count;
                this.txtTemplateStatus.Text = docTemplate.is_delete;
                this.txtTemplateName.Enabled = false;
                this.txtBreadth.Enabled = false;
                this.btnBrown.Enabled = false;
            }
        }

        #endregion 


        #region  按钮点击事件 
        /// <summary>
        /// 浏览点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrown_Click(object sender, EventArgs e)
        {
            // 浏览事件
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c://";
            open.Filter = "所有文件|*.*";
            open.RestoreDirectory = true;
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.txtFilePath.Text = open.FileName;
            }  
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            docTemplate.name = this.txtTemplateName.Text;
            docTemplate.breadth = this.txtBreadth.Text;
            docTemplate.id = int.Parse(this.txtTemplateId.Text);
            docTemplate.parent_name = this.txtTemplateType.Text;
            if (actionType == 1)
            {
                // 新建
                docTemplate = WcfServiceLocator.Create<IDocTemplateCategoryManage>().insertDocumentTemplate(docTemplate);
            }
            else if (actionType == 2)
            { 
                // 修改
                docTemplate = WcfServiceLocator.Create<IDocTemplateCategoryManage>().updateDocumentTemplate(docTemplate);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCannel_Click(object sender, EventArgs e)
        {
            // 取消事件
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion 
    }
}