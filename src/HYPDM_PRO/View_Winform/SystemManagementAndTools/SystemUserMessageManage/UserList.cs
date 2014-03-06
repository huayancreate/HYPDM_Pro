using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Services_Interface;
using PDM_Entity.SystemManagementAndTools;



namespace View_Winform.SystemManagementAndTools.SystemUserMessageManage
{
    public partial class UserList : DevExpress.XtraEditors.XtraForm
    {
        public Users user;
        public int userGroupID;
        
       
        public UserList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_SystemUserMessageManage_UserList_QueryUser_SimpleButton_Click(object sender, EventArgs e)
        {
            String condition = "where 1=1 ";


            if (SystemManagementAndTools_SystemUserMessageManage_UserList_UserCode_TextEdit.Text.Trim() != "")
            {
                condition += "and  login_name =" + SystemManagementAndTools_SystemUserMessageManage_UserList_UserCode_TextEdit.Text.Trim();
            }
            if (SystemManagementAndTools_SystemUserMessageManage_UserList_MobPhone_TextEdit.Text.Trim() != "")
            {
                condition += "and  mobile_phone =" + SystemManagementAndTools_SystemUserMessageManage_UserList_MobPhone_TextEdit.Text.Trim();
            }
            if (SystemManagementAndTools_SystemUserMessageManage_UserList_AuditStatus_ComboBoxEdit.Text.Trim() != "")
            {
                condition += "and  audit_state =" + SystemManagementAndTools_SystemUserMessageManage_UserList_AuditStatus_ComboBoxEdit.Text.Trim();
            }
            if (SystemManagementAndTools_SystemUserMessageManage_UserList_RealName_TextEdit.Text.Trim() != "")
            {
                condition += "and  real_name=" + SystemManagementAndTools_SystemUserMessageManage_UserList_RealName_TextEdit.Text.Trim();
            }
            if (SystemManagementAndTools_SystemUserMessageManage_UserList_Email_TextEdit.Text.Trim() != "")
            {
                condition += "and  email=" + SystemManagementAndTools_SystemUserMessageManage_UserList_Email_TextEdit.Text.Trim();
            }
            if (SystemManagementAndTools_SystemUserMessageManage_UserList_UserStatus_ComboBoxEdit.Text.Trim() != "")
            {
                condition += "and  state=" + SystemManagementAndTools_SystemUserMessageManage_UserList_UserStatus_ComboBoxEdit.Text.Trim();
            }

            findUser(condition);
        }
        private void UserList_Load(object sender, EventArgs e)
        {
            findUser("");//查询所有用户
            if ("EditRelatedUsers" == this.Tag)
            {

                IList<Users> listRelated = new BindingList<Users>();
                listRelated = WcfServiceLocator.Create<IUsersManage>().FindRelatedUsersForUserGroup(userGroupID); //找出和指定用户组关联的用户
                for (int i = 0; i < listRelated.Count; i++)
                {
                    
                    for (int j = 0; j < SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.RowCount; j++)
                    {

                        {
                            int id = (int)SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.GetRowCellValue(j, "id");
                            if (listRelated[i].id == id)
                            {
                                SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.SetRowCellValue(i, "isChecked", true);
                            }

                        }

                    }
                }

            }
            CommonPaging.gridView = SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView;
           
            SystemManagementAndTools_SystemUserMessageManage_UserList_UserStatus_ComboBoxEdit.Text = null;
            SystemManagementAndTools_SystemUserMessageManage_UserList_AuditStatus_ComboBoxEdit.Text = null;
            
        }

       

        /// <summary>
        /// 用户查询
        /// </summary>
        /// <param name="condition">查询条件</param>

        public void findUser(String condition)
        {
            IList<Users> list = new BindingList<Users>();
            list = WcfServiceLocator.Create<IUsersManage>().FindUser(condition);
            SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridControl.DataSource = list;
        }

        private void SystemManagementAndTools_SystemUserMessageManage_UserList_AddUser_SimpleButton_Click(object sender, EventArgs e)
        {
            
            UserMessage messageForm = new UserMessage();
            messageForm.ShowDialog();
        }
        /// <summary>
        /// 右击节点出现菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               popupMenu1.ShowPopup(Control.MousePosition);
            }

        }
        /// <summary>
        /// 判断菜单项是否可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            int select = SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.SelectedRowsCount;
            barButtonItem_Delete.Enabled = false;
            barButtonItem_Modify.Enabled = false;
            barButtonItem_Add.Enabled = true;
            barButtonItem_Details.Enabled = false;
            if (select == 1)
            {
                barButtonItem_Delete.Enabled = true;
                barButtonItem_Modify.Enabled = true;
                barButtonItem_Add.Enabled = true;
                barButtonItem_Details.Enabled = true;
            }
            if (select > 1)
            {
                barButtonItem_Delete.Enabled = true;
                barButtonItem_Add.Enabled = true;
                barButtonItem_Modify.Enabled = false;
            }

        }
        /// <summary>
        /// 右键菜单 修改用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem_Modify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            user = (Users)this.SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.GetFocusedRow();
           
            UserMessage messageForm = new UserMessage();
            messageForm.Tag = "Modify";

            messageForm.user = user;
            messageForm.ShowDialog();
            
        }
        /// <summary>
        /// 右键菜单 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteUser();
        }
        /// <summary>
        /// 右键菜单 用户详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void barButtonItem_Details_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            user = (Users)this.SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.GetFocusedRow();
            
            UserMessage messageForm = new UserMessage();
            messageForm.Tag = "Modify";
            messageForm.user = user;
            messageForm.ShowDialog();
        }
        /// <summary>
        /// 右键菜单 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserMessage messageForm = new UserMessage();
            messageForm.Tag = "Add";

            messageForm.ShowDialog();
        }
        /// <summary>
        /// 删除按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_SystemUserMessageManage_UserList_DeleteUser_SimpleButton_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
        
       
        /// <summary>
        /// 确定按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton_Click(object sender, EventArgs e)
        {
            if (this.Tag == "EditRelatedUsers")
            {
                //将用选中用户与指定用户组关联
                connectWithUserGroup();

            }
            

        }

        /// <summary>
        /// 添加用户与用户组关联
        /// </summary>
        public void connectWithUserGroup()
        {
            String value = "";
            int id;
            for (int i = 0; i < SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.RowCount; i++)
            {
                value = SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.GetRowCellValue(i, "isChecked").ToString();
                if (value == "True")
                {
                    id = (int)SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.GetRowCellValue(i, "id");
                    WcfServiceLocator.Create<IUsersManage>().AddRelatedGroup(id ,userGroupID);

                }

            }

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public void DeleteUser()
        {
            String value = "";
            int id;
            for (int i = 0; i < SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.RowCount; i++)
            {
                value = SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.GetRowCellValue(i, "isChecked").ToString();
                if (value == "True")
                {
                    id = (int)SystemManagementAndTools_SystemUserMessageManage_UserList_UserListMessage_GridView.GetRowCellValue(i, "id");
                    WcfServiceLocator.Create<IUsersManage>().DeleteUser(id);

                }

            }
        }
     }
}