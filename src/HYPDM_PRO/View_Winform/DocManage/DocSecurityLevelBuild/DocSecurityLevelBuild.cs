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

namespace View_Winform.DocManage.DocSecurityLevelBuild
{
    public partial class DocSecurityLevelBuild : DevExpress.XtraEditors.XtraForm
    {
        #region 自定义变量

        // 密级
        private List<dense> denseList = new List<dense>();

        //密级角色关系
        private List<dense_role> denseRoleList = new List<dense_role>();

        /// <summary>
        /// 构造函数
        /// </summary>
        public DocSecurityLevelBuild()
        {
            InitializeComponent();
        }

        #endregion

        #region  页面加载事件

        private void DocSecurityLevelBuild_Load(object sender, EventArgs e)
        {
            try
            {
                // 查询所有的秘密等级
                denseList = WcfServiceLocator.Create<IDocSecurityLevelBuild>().getAllDense();
                // 查询所有的角色密级关系
                denseRoleList = WcfServiceLocator.Create<IDocSecurityLevelBuild>().getAllDenseRole();
                // 循环给页面赋值
                //this.treeDense.treeList1
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region  页面点击事件

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEsc_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        
    }
}