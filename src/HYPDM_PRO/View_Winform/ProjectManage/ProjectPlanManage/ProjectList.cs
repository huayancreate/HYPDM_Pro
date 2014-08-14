using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using PDM_Entity.ProjectManage;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.ProjectManage.ProjectPlanManage
{
    public partial class ProjectList : DevExpress.XtraEditors.XtraForm
    {
        public ProjectList()
        {
            InitializeComponent();
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFindProjectList_Click(object sender, EventArgs e)
        {
            Hashtable conditioin = new Hashtable();
            List<ProjectBo> projects = WcfServiceLocator.Create<IProjectExportService>().getProjectsBySomeField(conditioin);
            gcProjectList.DataSource = projects;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var ganttchart = new GanttChart();
            ganttchart.Show();
        }
    }
}