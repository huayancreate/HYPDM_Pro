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
using System.Collections;

namespace View_Winform.ProjectManage.SporadicTaskManage
{
    public partial class ProjectTaskManage : DevExpress.XtraEditors.XtraForm
    {
        public ProjectTaskManage()
        {
            InitializeComponent();
        }

        private void btnFindDesign_Click(object sender, EventArgs e)
        {
            var conditions = new Hashtable();
            var sporadictask = WcfServiceLocator.Create<ISporadicTaskManageService>().getSporadicTaskBySomeConditions(conditions);
            groupControl8.Name = groupControl8.Name.Replace("{N}", sporadictask.Count.ToString());
            gcDesignTask.DataSource = sporadictask;
            gcDesignTask.RefreshDataSource();
            tlDesignTask.DataSource = WcfServiceLocator.Create<ISporadicTaskManageService>().getTaskTreeBySomeConditions(conditions);

        }

        private void ProjectTaskManage_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1, false);
            PackageCommon.SettingGridView(gridView2, false);
            PackageCommon.SettingGridView(gridView3, false);
            xtraTabControl5.Width = 360;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int id = 1;
            sporadicprojecttaskinfo(id);
        }
        private void sporadicprojecttaskinfo(int id)
        {
            var task = WcfServiceLocator.Create<ISporadicTaskManageService>().getSporadicTaskById(id);//1设计任务
            txtTaskName.Text = task.Name;
            textEdit5.Text = task.Creator;
            textEdit4.Text = task.PlanStartTime;
            textEdit3.Text = task.StartTime;
            textEdit2.Text = task.State;
            textEdit1.Text = task.WarningPercent.ToString();
            progressBarControl1.Position = task.Percent;
            textEdit13.Text = task.ParentName;
            textEdit12.Text = task.Executor;
            textEdit11.Text = task.PlanEndTime;
            textEdit10.Text = task.EndTime;
            textEdit9.Text = task.IsAnalysis;
            textEdit8.Text = task.WaringTime;
        }

        private void btnFindOffice_Click(object sender, EventArgs e)
        {
            var conditions = new Hashtable();
            var sporadictask = WcfServiceLocator.Create<ISporadicTaskManageService>().getSporadicTaskBySomeConditions(conditions);
            groupControl9.Name = groupControl9.Name.Replace("{N}", sporadictask.Count.ToString());

        }

        private void btnFindTechnology_Click(object sender, EventArgs e)
        {
            var conditions = new Hashtable();
            var sporadictask = WcfServiceLocator.Create<ISporadicTaskManageService>().getSporadicTaskBySomeConditions(conditions);
            groupControl9.Name = groupControl9.Name.Replace("{N}", sporadictask.Count.ToString());
            gcTechnology.DataSource = sporadictask;
            tlTechnology.DataSource = WcfServiceLocator.Create<ISporadicTaskManageService>().getTaskTreeBySomeConditions(conditions);
            xtraTabControl5.Width = 360;
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = 1;
            sporadictechnologytaskinfo(id);
        }
        private void sporadictechnologytaskinfo(int id)
        {
            var task = WcfServiceLocator.Create<ISporadicTaskManageService>().getSporadicTaskById(id);//1设计任务
            textEdit28.Text = task.Name;
            textEdit29.Text = task.Creator;
            textEdit30.Text = task.WhichProductName;
            textEdit31.Text = task.PlanStartTime;
            textEdit32.Text = task.StartTime;
            textEdit33.Text = task.WarningPercent.ToString();
            progressBarControl2.Position = task.Percent;
            //textEdit21.Text = task.WhichProductName;
            textEdit22.Text = task.Executor;
            textEdit23.Text = task.WhichProductVersion;
            textEdit24.Text = task.PlanEndTime;
            textEdit25.Text = task.EndTime;
            textEdit26.Text = task.WaringTime;
            textEdit31.Text = task.IsAnalysis;

        }
    }
}