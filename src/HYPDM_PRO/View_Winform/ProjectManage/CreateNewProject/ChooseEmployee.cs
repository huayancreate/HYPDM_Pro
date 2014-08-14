using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;

namespace View_Winform.ProjectManage.CreateNewProject
{
    public partial class ChooseEmployee : DevExpress.XtraEditors.XtraForm
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        private ICreateNewProjectService createProject;
        public ChooseEmployee()
        {
            InitializeComponent();
        }

        private void ChooseEmployee_Load(object sender, EventArgs e)
        {
            createProject = WcfExtension.WcfServiceLocator.Create<ICreateNewProjectService>();
            PackageCommon.SettingTreeList(tlRoles);
            PackageCommon.SettingTreeList(tlEmployees);
            tlRoles.DataSource = createProject.GetProjectRoles();
        }

        private void tlRoles_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            int id = Convert.ToInt32(e.Node.GetValue("ID"));
            tlEmployees.DataSource = createProject.GetEmpoyeesByRoleID(id);
        }

        private void tlEmployees_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            UserID = Convert.ToInt32(e.Node.GetValue("Column_1"));
            Username = e.Node.GetValue("Name").ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Username) || UserID == 0)
            {
                MessageBox.Show(this, "请选择一个负责人.", "项目管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}