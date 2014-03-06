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

namespace View_Winform.DocManage.DocGrantManage
{
    public partial class DocGrantHistoryQuery : DevExpress.XtraEditors.XtraForm
    {
        #region 自定义变量
        //获取查询的集合
        private List<doc_grant_setting> grantSettingList = new List<doc_grant_setting>();

        public DocGrantHistoryQuery()
        {
            InitializeComponent();
        }
        #endregion 


        #region 页面点击事件

        /// <summary>
        /// 查询历史记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEdit1.Checked)
                {
                    // 根据发放设置查询条件，进行查询
                    doc_grant_setting doc_grant_setting = new doc_grant_setting();
                    doc_grant_setting.grant_user = this.textEdit1.Text;
                    doc_grant_setting.grant_user = this.textEdit2.Text;
                    doc_grant_setting.valid_time = this.textEdit7.Text;
                    grantSettingList = WcfServiceLocator.Create<IDocGrantManage>().getGrantSetting(doc_grant_setting);
                    dgcGrant.DataSource = grantSettingList;
                }
                else
                {
                    // 根据文档查询条件，进行查询
                    document doc = new document();
                    doc.number = this.textEdit3.Text;
                    doc.version = this.textEdit4.Text;
                    doc.cn_name = this.textEdit5.Text;
                    doc.create_user_name = this.textEdit6.Text;
                    grantSettingList = WcfServiceLocator.Create<IDocGrantManage>().getGrantSettingByDoc(doc);
                    dgcGrant.DataSource = grantSettingList;
                }
                dgcGrant.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// 点击单元格，联动文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGrant_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // 获取选中行
            doc_grant_setting doc_grant_setting = (doc_grant_setting)this.dgvGrant.GetFocusedRow();
            // 绑定数据
            this.dgcDocument.DataSource = doc_grant_setting.document_list;
            this.dgcDocument.RefreshDataSource();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 自定义导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportUserDefine_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 输出导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportGrant_Click(object sender, EventArgs e)
        {

        }

        #endregion 

        

       

        

        

        
    }
}