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


namespace View_Winform.SystemManagementAndTools.RoleManage
{
    public partial class RoleManage : DevExpress.XtraEditors.XtraForm
    {
        public Role role;
        public RoleManage()
        {
            InitializeComponent();
        }

        private void RoleManage_Load(object sender, EventArgs e)
        {
            SystemManagementAndTools_RoleManage_RoleManage_Name_TextEidt.Text = role.name;
            SystemManagementAndTools_RoleManage_RoleManage_Describe_MemoEdit.Text = role.Remark;
            SystemManagementAndTools_RoleManage_RoleList_OperationList_conmmonListBoxControl.controlText = "可操作功能";
            SystemManagementAndTools_RoleManage_RoleList_OperationList_conmmonListBoxControl.commonMark = "EditRelatedOperetionWithRole";
            SystemManagementAndTools_RoleManage_RoleList_MenuList_conmmonListBoxControl.controlText = "可操作菜单";
           
            SystemManagementAndTools_RoleManage_RoleList_MenuList_conmmonListBoxControl.commonMark = "EditRelatedMenuWithRole";
            SystemManagementAndTools_RoleManage_RoleList_RelatedUser_conmmonListBoxControl.controlText = "包含用户";
            SystemManagementAndTools_RoleManage_RoleList_RelatedUser_conmmonListBoxControl.conmmonID = role.Id;

            SystemManagementAndTools_RoleManage_RoleList_RelatedUser_conmmonListBoxControl.commonMark = "EditRelatedUsersWithRole";
            SystemManagementAndTools_RoleManage_RoleList_RelatedGroup_conmmonListBoxControl.controlText = "包含用户组";
            SystemManagementAndTools_RoleManage_RoleList_RelatedUser_conmmonListBoxControl.conmmonID = role.Id;


            SystemManagementAndTools_RoleManage_RoleList_RelatedGroup_conmmonListBoxControl.commonMark = "EditRelatedUserGroupWithRole";

            if (this.Tag == "Modify")
            {
                SystemManagementAndTools_RoleManage_RoleList_RelatedUser_conmmonListBoxControl.usersList = WcfServiceLocator.Create<IRoleManage>().findRelatedUser(role.Id);
                SystemManagementAndTools_RoleManage_RoleList_RelatedGroup_conmmonListBoxControl.groupList = WcfServiceLocator.Create<IRoleManage>().findRelatedGroup(role.Id);
                SystemManagementAndTools_RoleManage_RoleList_OperationList_conmmonListBoxControl.operationList = WcfServiceLocator.Create<IRoleManage>().findRelatedOperation(role.Id);
                SystemManagementAndTools_RoleManage_RoleList_MenuList_conmmonListBoxControl.menuList = WcfServiceLocator.Create<IRoleManage>().findRelatedMenu(role.Id);

            }

        }
    }
}