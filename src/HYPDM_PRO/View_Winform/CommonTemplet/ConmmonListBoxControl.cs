using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.SystemManagementAndTools;
using View_Winform.SystemManagementAndTools.SystemUserMessageManage;
using View_Winform.SystemManagementAndTools.UserGroupManage;

namespace View_Winform.CommonTemplet
{
    public partial class ConmmonListBoxControl : DevExpress.XtraEditors.XtraUserControl
    {
        public int conmmonID { get; set; }
        public String commonMark { get; set; }
        public String controlText { get; set; }
        public List<String> item = new List<String>();
        public IList<Users> usersList = new BindingList<Users>();
        public IList<Role> roleList = new BindingList<Role>();
        public IList<Group> groupList = new BindingList<Group>();
        public IList<Operation> operationList = new BindingList<Operation>();
        public IList<Menus> menuList = new BindingList<Menus>();
        public ConmmonListBoxControl()
        {
            InitializeComponent();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            if (controlText != null)
            {
                groupControl1.Text = controlText;
            }
            if (usersList.Count != 0)
            {
                listBoxControl1.DisplayMember = "login_name";
                listBoxControl1.DataSource = usersList;

            }
            if (roleList.Count != 0)
            {
                listBoxControl1.DisplayMember = "name";
                listBoxControl1.DataSource = roleList;
            }
            if (groupList.Count != 0)
            {
                listBoxControl1.DisplayMember = "Name";
                listBoxControl1.DataSource = groupList;
            }

            if (operationList.Count != 0)
            {
                listBoxControl1.DisplayMember = "Name";
                listBoxControl1.DataSource = operationList;
            }
            if (menuList.Count != 0)
            {
                listBoxControl1.DisplayMember = "Name";
                listBoxControl1.DataSource = menuList;
            }

        }

        private void simpleButton_Edit_Click(object sender, EventArgs e)
        {
            if (this.commonMark == "EditRelatedUsersWithUserGroup")
            {
                UserList list = new UserList();
                list.Tag = this.commonMark;  //定义编辑关联用户标识
                list.Show();
            }
            if (this.commonMark == "EditRelatedUsersWithRole")
            {
                UserList list = new UserList();
                list.Tag = this.commonMark;  //定义编辑关联用户标识
                list.roleID = this.conmmonID;
                list.Show();
            }
            if (this.commonMark == "EditRelatedOperetionWithRole") 
            {
               MessageBox.Show("查询和角色关联的操作");
            }
            if (this.commonMark == "EditRelatedMenuWithRole")
            {
                MessageBox.Show("查询和角色关联的菜单");
            }
            if (this.commonMark == "EditRelatedUserGroupWithRole")
           {
                UserGroupList list = new UserGroupList();
                list.Tag = commonMark;
                list.roleID = this.conmmonID;
                list.Show();
                
           }


        }
    }
}
