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
using System.Web.UI;


namespace View_Winform.SystemManagementAndTools.SystemUserMessageManage
{
 
   
     public partial class UserMessage : DevExpress.XtraEditors.XtraForm
    {
        
        public Users user;

        public UserMessage()
        {
            InitializeComponent();
        }
        
       
     private void UserMessage_Load(object sender, EventArgs e)
        {
            
            if (this.Tag == "Modify")
            {
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_LoginName_TextEdit.Text = user.login_name;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_RealName_TextEdit.Text = user.real_name;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_SubordinateCompanies_ComboBoxEdit.Text = user.company_id.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_DefaultDepartment_ComboBoxEdit.Text = user.default_department;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_ImmediateManager_ComboBoxEdit.Text = user.immediate_manager;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_UserNumber_TextEdit.Text = user.user_number;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_Major_TextEdit.Text = user.major;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_IdCard_TextEdit.Text = "34112222221";
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_Sex_ComboBoxEdit.Text = user.sex;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_Birthday_DateEidte.Text = user.birthday.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_MobileTelephone_TextEdit.Text = user.mobile_phone;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_OfficePhone_TextEdit.Text = user.office_phone;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_Address_TextEdit.Text = "西伯利亚大沙漠边缘地带";
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_StorKey_TextEdit.Text = user.stor_key;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_Mail_TextEdit.Text = user.email;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_CompanyId_TextEdit.Text = user.company_id.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_Remark_MemoEdit.Text = user.remark;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_AuditState_ComboBoxEdit.Text = user.audit_state;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_State_ComboBoxEdit.Text = user.state;
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_CreateUserId_TextEdit.Text = user.create_user_id.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_CreateDate_ComboBoxEdit.Text = user.create_date.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_ModifyUserId_TextEdit.Text = user.modify_user_id.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_ModifyDate_ComboBoxEdit.Text = user.modify_date.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_LoginTime_ComboBoxEdit.Text = user.logout_time.ToString();
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_ExitTime_ComboBoxEdit.Text = user.logout_time.ToString();

                Role role = WcfServiceLocator.Create<IUsersManage>().FindRole(user.id);
                MessageBox.Show(role.name);
                SystemManagementAndTools_SystemUserMessageManage_UserMessage_RelatedRole_ConmmonListBoxControl.value = role.name;
                

            }
            
           
        }

     private void SystemManagementAndTools_SystemUserMessageManage_UserMessage_Submmit_SimpleButton_Click(object sender, EventArgs e)
     {
          Users userModifyed = new Users();
          userModifyed.login_name=SystemManagementAndTools_SystemUserMessageManage_UserMessage_LoginName_TextEdit.Text;
          userModifyed.real_name=SystemManagementAndTools_SystemUserMessageManage_UserMessage_RealName_TextEdit.Text;
          // userModifyed.company_id=SystemManagementAndTools_SystemUserMessageManage_UserMessage_SubordinateCompanies_ComboBoxEdit.Text;
          userModifyed.default_department=SystemManagementAndTools_SystemUserMessageManage_UserMessage_DefaultDepartment_ComboBoxEdit.Text;
          userModifyed.immediate_manager=SystemManagementAndTools_SystemUserMessageManage_UserMessage_ImmediateManager_ComboBoxEdit.Text;
          userModifyed.user_number=SystemManagementAndTools_SystemUserMessageManage_UserMessage_UserNumber_TextEdit.Text;
          userModifyed.major=SystemManagementAndTools_SystemUserMessageManage_UserMessage_Major_TextEdit.Text;
          //SystemManagementAndTools_SystemUserMessageManage_UserMessage_IdCard_TextEdit.Text; 数据库中无身份证号码字段
          userModifyed.sex=SystemManagementAndTools_SystemUserMessageManage_UserMessage_Sex_ComboBoxEdit.Text;
          //userModifyed.birthday = SystemManagementAndTools_SystemUserMessageManage_UserMessage_Birthday_DateEidte.Text; 无法将字符创类型转换成DateTime类型


          userModifyed.mobile_phone=SystemManagementAndTools_SystemUserMessageManage_UserMessage_MobileTelephone_TextEdit.Text;
          userModifyed.office_phone=SystemManagementAndTools_SystemUserMessageManage_UserMessage_OfficePhone_TextEdit.Text;
          //SystemManagementAndTools_SystemUserMessageManage_UserMessage_Address_TextEdit.Text = "西伯利亚大沙漠边缘地带";
          userModifyed.stor_key = SystemManagementAndTools_SystemUserMessageManage_UserMessage_StorKey_TextEdit.Text;
          userModifyed.email =SystemManagementAndTools_SystemUserMessageManage_UserMessage_Mail_TextEdit.Text;
          //userModifyed.company_id=SystemManagementAndTools_SystemUserMessageManage_UserMessage_CompanyId_TextEdit.Text; 无法将字串类型转换成int类型
          userModifyed.remark=SystemManagementAndTools_SystemUserMessageManage_UserMessage_Remark_MemoEdit.Text;
          userModifyed.audit_state=SystemManagementAndTools_SystemUserMessageManage_UserMessage_AuditState_ComboBoxEdit.Text;
          userModifyed.state=SystemManagementAndTools_SystemUserMessageManage_UserMessage_State_ComboBoxEdit.Text;
          //userModifyed.create_user_id=SystemManagementAndTools_SystemUserMessageManage_UserMessage_CreateUserId_TextEdit.Text; 无法将字串类型转换成int类型
          //userModifyed.create_date=SystemManagementAndTools_SystemUserMessageManage_UserMessage_CreateDate_ComboBoxEdit.Text;  无法将字符创类型转换成DateTime类型
          //userModifyed.create_user_id=SystemManagementAndTools_SystemUserMessageManage_UserMessage_ModifyUserId_TextEdit.Text;
          //userModifyed.create_date=SystemManagementAndTools_SystemUserMessageManage_UserMessage_ModifyDate_ComboBoxEdit.Text;
          //userModifyed.login_time=SystemManagementAndTools_SystemUserMessageManage_UserMessage_LoginTime_ComboBoxEdit.Text;
          //userModifyed.logout_time=SystemManagementAndTools_SystemUserMessageManage_UserMessage_ExitTime_ComboBoxEdit.Text;

           bool ok = WcfServiceLocator.Create<IUsersManage>().ModifyUser(userModifyed);
           MessageBox.Show(ok.ToString());
      }
    }
}