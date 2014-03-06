using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;

namespace View_Winform.DocManage.DocGrantManage
{
    public partial class GrantInfoBuild : DevExpress.XtraEditors.XtraForm
    {
        #region  自定义变量
        
        // 页面传递参数
        public doc_grant_setting docGrantSetting
        {
            get;
            set;
        }

        public GrantInfoBuild()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="docGrantSetting"></param>
        public GrantInfoBuild(doc_grant_setting docGrantSetting)
        {
            InitializeComponent();
            this.docGrantSetting = docGrantSetting;
        }

        #endregion 

        #region  窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrantInfoBuild_Load(object sender, EventArgs e)
        {
            if (docGrantSetting != null)
            {
                // 权限天数
                 this.txtValid.Text = docGrantSetting.valid;
                // 是否默认
                this.chkDefault.Checked = docGrantSetting.is_default == "Y"?  true : false;
                
                // 权限
                if (docGrantSetting.permission_type_name == "控件浏览")
                {
                    this.chkPermission.SelectedIndex = 0;
                }
                else if (docGrantSetting.permission_type_name == "浏览")
                {
                    this.chkPermission.SelectedIndex = 1;
                }
                else if (docGrantSetting.permission_type_name == "下载")
                {
                    this.chkPermission.SelectedIndex = 2;
                }
                else
                {
                    this.chkPermission.SelectedIndex = 0;
                }
                
            }
        }
        #endregion 


        #region  页面点击事件
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (docGrantSetting == null)
            {
                docGrantSetting = new doc_grant_setting();
            }
            // 权限天数
            docGrantSetting.valid = this.txtValid.Text;
            // 是否默认
            docGrantSetting.is_default = this.chkDefault.Checked ? "Y" : "N";
            // 权限
            if(this.chkPermission.SelectedIndex ==0 )
            {
                docGrantSetting.permission_type_name = "控件浏览";
            }else if(this.chkPermission.SelectedIndex ==1 )
            {
                docGrantSetting.permission_type_name = "浏览";
            }else if(this.chkPermission.SelectedIndex ==2 )
            {
                docGrantSetting.permission_type_name = "下载";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion 

       
    }
}