using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.SystemManagementAndTools;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.SystemManagementAndTools.UserGroupManage
{
    public partial class UserGroupManage : DevExpress.XtraEditors.XtraForm
    {
        public Group group;
        public UserGroupManage()
        {
            InitializeComponent();
        }

        private void UserGroupManage_Load(object sender, EventArgs e)
        {
            if (this.Tag == "Modify")
            {
                SystemManagementAndTools_UserGroupManage_Name_TextEdit.Text = group.Name;
                SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Text = group.Remark;
            }
            if (this.Tag =="Add")
            {

            }


        }
        /// <summary>
        /// 保存按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_UserGroupManage_Save_SimpleButton_Click(object sender, EventArgs e)
        {
            Group groupNew = new Group();
            bool ok = false;
            groupNew.Name = SystemManagementAndTools_UserGroupManage_Name_TextEdit.Text;
            groupNew.Remark = SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Text;


            ok=WcfServiceLocator.Create<IUserGroupManage>().AddGroup(groupNew);
            MessageBox.Show(ok.ToString());
            
        }
    }
}