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
using System.Collections;
using DevExpress.XtraTreeList.Nodes;
using View_Winform.ProjectManage.ProjectCalendarBuild;
using DevExpress.XtraGrid.Views.Grid;

namespace View_Winform.ProjectManage.ProjectExport
{
    public partial class ProjectExport : DevExpress.XtraEditors.XtraForm
    {
        public ProjectExport()
        {
            InitializeComponent();
        }

        private void ProjectExport_Load(object sender, EventArgs e)
        {
            List<ProjectTypeBo> projectTypes = WcfServiceLocator.Create<IProjectExportService>().getAllProjectTypes();
            tlProjectType.DataSource = projectTypes;
            tlProjectType.ParentFieldName = "ParentId";
            tlProjectType.KeyFieldName = "Id";
            List<ProjectBo> projects = WcfServiceLocator.Create<IProjectExportService>().getAllProjects();
            gcProjectList.DataSource = projects;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Hashtable conditioin = new Hashtable();
            List<ProjectBo> projects = WcfServiceLocator.Create<IProjectExportService>().getProjectsBySomeField(conditioin);
            gcProjectList.DataSource = projects;
        }

        private void tlProjectType_Click(object sender, EventArgs e)
        {
            TreeListNode tlfocuse = tlProjectType.FocusedNode;
            int groupid = Convert.ToInt32(tlfocuse.GetDisplayText("Id"));
            List<ProjectBo> projects = WcfServiceLocator.Create<IProjectExportService>().getProjectsByGroupId(groupid);
            gcProjectList.DataSource = projects;
        }

        private void gvProjects_RowClick(object sender, RowClickEventArgs e)
        {
            if(e.Clicks!=2)return;
            ProjectBo p = new ProjectBo();
            p.Id = (int)gvProjects.GetRowCellValue(e.RowHandle, "Id");
            p.Name = (string)gvProjects.GetRowCellValue(e.RowHandle, "Name");
            p.StartTime = (string)gvProjects.GetRowCellValue(e.RowHandle, "StartTime");

            ProjectCalendar pc = new ProjectCalendar();
            pc.project = p;
            pc.ShowDialog();
           
        }
    }
}