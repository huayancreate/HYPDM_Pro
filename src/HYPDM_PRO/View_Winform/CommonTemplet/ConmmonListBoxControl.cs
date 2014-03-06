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

namespace View_Winform.CommonTemplet
{
    public partial class ConmmonListBoxControl : DevExpress.XtraEditors.XtraUserControl
    {
      
        public String controlText { get; set; }
        public List<String> item = new List<String>();
        public IList<Users> usersList = new BindingList<Users>();
        public IList<Role>  roleList = new BindingList<Role>();
        
        public ConmmonListBoxControl()
        {
            InitializeComponent();
           
        }
       
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            if(controlText!=null)
            {
                groupControl1.Text=controlText;
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
        }

        private void simpleButton_Edit_Click(object sender, EventArgs e)
        {
            if (groupControl1.Text == "包含用户")
            {
                UserList list = new UserList();
                list.Tag = "EditRelatedUsers";  //定义编辑关联用户标识
                list.Show();
            }
            if (groupControl1.Text == "包含角色")
            {

            }
            
        }
    }
}
