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

namespace View_Winform.ProjectManage.ProjectPlanManage
{
    public partial class TaskResolve : DevExpress.XtraEditors.XtraForm
    {
        List<InputInformationbo> InputInformations;
        public TaskResolve()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TaskBo task = new TaskBo();
            WcfServiceLocator.Create<IProjectPlanManageService>().saveTask(task);
        }

        public int projectid { get; set; }

        private void tbWarning_EditValueChanged(object sender, EventArgs e)
        {
            this.lblWarningDigitize.Text = (sender as TrackBarControl).Value + "%";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TaskResolve_Load(object sender, EventArgs e)
        {
            InputInformations = new List<InputInformationbo>();
            var projectgroup = WcfServiceLocator.Create<IProjectPlanManageService>().getProjectGroupUsersByIdProjectId(projectid);
            var tasks = WcfServiceLocator.Create<IProjectPlanManageService>().getTasksByProjectId(projectid);
            gcProjectGroup.DataSource = projectgroup;
            gcTasks.DataSource = tasks;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var tasks = WcfServiceLocator.Create<IProjectPlanManageService>().getTasksByUserId(projectid);
            gcTasks.DataSource = tasks;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var createprojectdoc = new CreateProjectDoc();
            createprojectdoc.ShowDialog();
            InputInformations.Add(createprojectdoc.inputinformation);
            gcInputInformation.DataSource = InputInformations;
        }

        private void btnAddPretask_Click(object sender, EventArgs e)
        {
            var addinputinfo = new AddInputInformation();
            addinputinfo.ShowDialog();
        }
    }
}