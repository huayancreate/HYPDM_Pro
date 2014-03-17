using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Entity.SystemManagementAndTools;
using PDM_Services_Interface;



namespace View_Winform.SystemManagementAndTools.RoleManage
{
    public partial class RoleList : DevExpress.XtraEditors.XtraForm
    {
        public RoleList()
        {
            InitializeComponent();
        }

       
        private void RoleList_Load(object sender, EventArgs e)
        {
            IList<Role> list = new BindingList<Role>();
            list=WcfServiceLocator.Create<IRoleManage>().findRole("");
            SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridControl.DataSource = list;
            SystemManagementAndTools_RoleManage_RoleList_CommonPage_CommonTemplet.gridView=SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridView;
        }

        private void SystemManagementAndTools_RoleList_QueryRole_SimpleButton_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Id = 1;
            role.name = "s";
            bool ok = true;
            ok = WcfServiceLocator.Create<IRoleManage>().AddRole(role);
            MessageBox.Show(ok.ToString());
        }
        private void SystemManagementAndTools_RoleList_AddRole_SimpleButton_Click(object sender, EventArgs e)
        {
            RoleManage roleManage = new RoleManage();
            roleManage.Tag = "Add";
        }

        private void SystemManagementAndTools_RoleList_DeleteRole_SimpleButton_Click(object sender, EventArgs e)
        {
            DeleteRole();
        }

        private void SystemManagementAndTools_RoleList_Confirm_SimpleButton_Click(object sender, EventArgs e)
        {

        }

       

        private void SystemManagementAndTools_RoleManage_RoleList_ModifyRole_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RoleManage roleManage = new RoleManage();
            roleManage.Tag = "Modify";
            roleManage.role = (Role)SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridView.GetFocusedRow();
            roleManage.Show();
        }

        private void SystemManagementAndTools_RoleManage_RoleList_DeleteRole_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteRole();
        }

        private void SystemManagementAndTools_RoleManage_RoleList_Details_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RoleManage roleManage = new RoleManage();
            roleManage.Tag = "Modify";
            roleManage.role = (Role)SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridView.GetFocusedRow();
            roleManage.Show();
        }

        private void SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        public void DeleteRole()
        {
            String value = "";
            int id;
            int checkMark = 0;
            for (int i = 0; i < SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridView.RowCount; i++)
            {
                value = SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridView.GetRowCellValue(i, "isChecked").ToString();
                if (value == "True")
                {
                    checkMark++;
                    id = (int)SystemManagementAndTools_RoleManage_RoleList_RoleListMessage_GridView.GetRowCellValue(i, "Id");
                    MessageBox.Show("id=" + id.ToString());
                    WcfServiceLocator.Create<IRoleManage>().DeleteRole(id);
                }

            }
            if (checkMark == 0)
            {
                MessageBox.Show("请选择一个角色");
            }
        }

    }
}