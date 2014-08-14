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
using PDM_Entity.ProjectManage;
using System.ServiceModel;

namespace View_Winform.ProjectManage.ProjectFlowDefinition
{
    public partial class ProjectFlowDefinition : DevExpress.XtraEditors.XtraForm
    {
        List<ProjectProcessbo> allProjectProcess;
        List<ProjectProcessbo> mineProjectProcess;
        public ProjectFlowDefinition()
        {
            InitializeComponent();
        }

        private void rgProcessSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = rgProcessSwitch.SelectedIndex;
            switch (itemIndex)
            {
                case 0: { pcNewProcess.Visible = true; pcOpenProcess.Visible = false; Text = "新建流程模版"; } break;
                case 1: { pcNewProcess.Visible = false; pcOpenProcess.Visible = true; Text = "打开流程模版"; } break;
            }
        }

        private void ProjectFlowDefinition_Load(object sender, EventArgs e)
        {
            allProjectProcess = WcfServiceLocator.Create<IProjectFlowDefinitionService>().getAllProjectProcess();
            mineProjectProcess = WcfServiceLocator.Create<IProjectFlowDefinitionService>().getProjectProcessByUserId(1);
            gcProcessList.DataSource = allProjectProcess;
        }

        private void chkIsMine_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsMine.Checked)
            {
                gcProcessList.DataSource = mineProjectProcess;
            }
            else
            {
                gcProcessList.DataSource = allProjectProcess;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }
    }
}