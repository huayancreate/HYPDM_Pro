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
using PDM_Entity.SystemManagementAndTools;

namespace View_Winform.SystemManagementAndTools.UserGroupManage
{
    public partial class UserGroupList : DevExpress.XtraEditors.XtraForm
    {
        public Group group;
        public UserGroupList()
        {
            InitializeComponent();
        }

        private void UserGroupList_Load(object sender, EventArgs e)
        {
           //  String condition = SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.Text;
           // WcfServiceLocator.Create<IUserGroupManage>().findGroup(condition);
        }

        //加载用户组信息
        public void listAllUserGourp()
        {
            
        }
        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton_Click(object sender, EventArgs e)
        {
            String condition = SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.Text;
            SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.DataSource=WcfServiceLocator.Create<IUserGroupManage>().findGroup(condition);
        }
        /// <summary>
        /// 添加按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton_Click(object sender, EventArgs e)
        {
            UserGroupManage userGroup = new UserGroupManage();
            userGroup.Tag = "Add";

            userGroup.ShowDialog();
        }
        /// <summary>
        /// 删除按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton_Click(object sender, EventArgs e)
        {
               DeleteGroup();
        }

        /// <summary>
        ///删除用户组
        /// </summary>
        public void DeleteGroup()
        {
            String value = "";
            int id;
            int checkMark=0;
            for (int i = 0; i < SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.RowCount; i++)
            {
                value = SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.GetRowCellValue(i, "isChecked").ToString();
                if (value == "True")
                {
                    checkMark++;
                    id = (int)SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.GetRowCellValue(i, "Id");
                    MessageBox.Show("id="+id.ToString());
                    WcfServiceLocator.Create<IUserGroupManage>().DeleteGroup(id);

                }

            }
            if (checkMark == 0)
            {
                MessageBox.Show("请选择一个用户组");
            }
        }

        private void SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
        /// <summary>
        /// 右键菜单单击事件 添加用户组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserGroupManage userGroup = new UserGroupManage();
            userGroup.Tag = "Add";

            userGroup.ShowDialog();
        }
        /// <summary>
        /// 右键菜单单击事件 修改用户组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem_Modify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            group = (Group)SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.GetFocusedRow();
            UserGroupManage userGroup = new UserGroupManage();
            userGroup.Tag = "Modify";
            userGroup.group = group;
            userGroup.ShowDialog();

        }
        /// <summary>
        /// 右键菜单单击事件 删除用户组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteGroup();
        }
        /// <summary>
        /// 右键菜单单击事件 用户组详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem_Details_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        
    }
}