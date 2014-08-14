using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Services_Interface;
using System.Collections;
using PDM_Entity.MyTaskBox;

namespace View_Winform.MyTaskBox
{
    public partial class MyTask : DevExpress.XtraEditors.XtraForm
    {
        List<CheckSignTask> checksigntasks;
        IMyTaskBoxService myTaskBoxService;
        public MyTask()
        {
            InitializeComponent();
        }

        private void MyTask_Load(object sender, EventArgs e)
        {
            myTaskBoxService = WcfServiceLocator.Create<IMyTaskBoxService>();
            PackageCommon.SettingGridView(gridView1);
            PackageCommon.SettingGridView(gridView2);
            PackageCommon.SettingGridView(gridView3);
            PackageCommon.SettingGridView(gridView4);
            PackageCommon.SettingGridView(gridView5);
            PackageCommon.SettingGridView(gridView6);
            PackageCommon.SettingGridView(gridView7);
            PackageCommon.SettingGridView(gridView8);
            PackageCommon.SettingGridView(gridView9);
            PackageCommon.SettingGridView(gridView10);
            PackageCommon.SettingGridView(gridView11);
            PackageCommon.SettingGridView(gridView12);
            PackageCommon.SettingGridView(gridView13);
            PackageCommon.SettingGridView(gridView14);
            PackageCommon.SettingGridView(gridView15);
            PackageCommon.SettingTreeList(tlAudit);
            PackageCommon.SettingTreeList(tlOffice);
            PackageCommon.SettingTreeList(tlProject);
            PackageCommon.SettingTreeList(tlDesign);
            PackageCommon.SettingTreeList(tlChange);
            PackageCommon.SettingTreeList(tlCraft);
            PackageCommon.SettingTreeList(tlApply);
            pcTaskManage.Location = new Point(200, 5);
            tlAudit.DataSource = myTaskBoxService.getCheckandSignedTasks();
            tlAudit.ExpandAll();
            tlOffice.DataSource = myTaskBoxService.getOfficeTasks();
            tlOffice.ExpandAll();
            tlProject.DataSource = myTaskBoxService.getProjectTasks();
            tlProject.ExpandAll();
            tlDesign.DataSource = myTaskBoxService.getDesignTasks();
            tlDesign.ExpandAll();
            tlChange.DataSource = myTaskBoxService.getChangeTasks();
            tlDesign.ExpandAll();
            tlCraft.DataSource = myTaskBoxService.getCraftTasks();
            tlCraft.ExpandAll();
            tlApply.DataSource = myTaskBoxService.getToApplyForBusinessTrip();
            tlApply.ExpandAll();
        }
        /// <summary>
        /// 审签任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlAudit_Click(object sender, EventArgs e)
        {
            var name = tlAudit.FocusedNode.GetValue("Name");
            if (name.Equals("任务管理"))
            {
                pcTaskManage.Visible = true;
            }
            else
            {
                pcTaskManage.Visible = false;
            }
        }

        private void btnCheckSignQuery_Click(object sender, EventArgs e)
        {
            var c = new Hashtable();
            checksigntasks = myTaskBoxService.getCheckandSignedTasksByCondition(c);
            gcAuditTasks.DataSource = checksigntasks;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var c = new Hashtable();
            gcTaskManage.DataSource = myTaskBoxService.getCheckandSignedTasksByCondition(c);
        }

        private void btnOfficeQuery_Click(object sender, EventArgs e)
        {
            var c = new Hashtable();
            gcOfficeTasks.DataSource = myTaskBoxService.getOfficeTasksByCondition(c);
        }
        /// <summary>
        /// 办公任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlOffice_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 项目任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlProject_Click(object sender, EventArgs e)
        {
            gcProjectTasks.DataSource = myTaskBoxService.getProjectTasksByTaskType(0);
        }
        /// <summary>
        /// 设计任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlDesign_Click(object sender, EventArgs e)
        {
            gcDesignTasks.DataSource = myTaskBoxService.getDesignTasksByTaskType(0);
        }
        /// <summary>
        /// 变更任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlChange_Click(object sender, EventArgs e)
        {
            gcDesignTasks.DataSource = myTaskBoxService.getChangeTasksByTaskType(0);
        }
        /// <summary>
        /// 工艺任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlCraft_Click(object sender, EventArgs e)
        {
            gcCraftTasks.DataSource = myTaskBoxService.getCraftTasksByTaskType(1);
        }
        /// <summary>
        /// 出差申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlApply_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "ID"));
            var cst = checksigntasks.Where(c => c.ID == id).ToList<CheckSignTask>();
            gcTaskNode.DataSource = myTaskBoxService.getTaskNodesByTaskID(id);
            gcExecutor.DataSource = myTaskBoxService.getExecutorByTaskID(id);
            gcNodeProcess.DataSource = myTaskBoxService.getNodeProcessByTaskID(id);
        }
        private void gridView8_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var taskbo = myTaskBoxService.getTaskById(1);
            textEdit8.Text = taskbo.Name;
            textEdit9.Text = taskbo.State;
            textEdit10.Text = taskbo.BelongProject;
            textEdit11.Text = taskbo.BelongProduct;
            textEdit12.Text = taskbo.Creator;
            textEdit13.Text = taskbo.Executor;
            textEdit14.Text = taskbo.PlanStartTime;
            textEdit15.Text = taskbo.PlanEndTime;
            textEdit16.Text = taskbo.EarliestStartTime;
            textEdit17.Text = taskbo.LatereEinddatum;
            textEdit18.Text = taskbo.StartTime;
            textEdit19.Text = taskbo.EndTime;
            textEdit20.Text = taskbo.WarningPercentage;
            textEdit21.Text = taskbo.WarningTime;
            textEdit22.Text = taskbo.WhetherItCanDecompose;
            memoEdit3.Text = taskbo.Description;
            memoEdit4.Text = taskbo.Remark;
            progressBarControl1.Position = taskbo.Percent;
        }

        private void gridView9_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var taskbo = myTaskBoxService.getTaskById(1);
            textEdit38.Text = taskbo.Name;
            textEdit37.Text = taskbo.BelongTask;
            textEdit34.Text = taskbo.Creator;
            textEdit33.Text = taskbo.Executor;
            textEdit32.Text = taskbo.PlanStartTime;
            textEdit31.Text = taskbo.PlanEndTime;
            textEdit28.Text = taskbo.StartTime;
            textEdit27.Text = taskbo.EndTime;
            textEdit29.Text = taskbo.State;
            textEdit24.Text = taskbo.WhetherItCanDecompose;
            textEdit26.Text = taskbo.WarningPercentage;
            textEdit25.Text = taskbo.WarningTime;
            memoEdit6.Text = taskbo.Description;
            memoEdit5.Text = taskbo.Remark;
            progressBarControl2.Position = taskbo.Percent;
        }

        private void gridView13_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var taskbo = myTaskBoxService.getTaskById(1);
            textEdit50.Text = taskbo.Name;
            textEdit49.Text = taskbo.BelongTask;
            textEdit48.Text = taskbo.Creator;
            textEdit47.Text = taskbo.Executor;
            textEdit46.Text = taskbo.BelongProject;
            textEdit45.Text = taskbo.BelongProduct;
            textEdit44.Text = taskbo.PlanStartTime;
            textEdit43.Text = taskbo.PlanEndTime;
            textEdit42.Text = taskbo.StartTime;
            textEdit41.Text = taskbo.EndTime;
            textEdit40.Text = taskbo.WarningPercentage;
            textEdit39.Text = taskbo.WarningTime;
            textEdit36.Text = taskbo.State;
            textEdit35.Text = taskbo.WhetherItCanDecompose;
            memoEdit8.Text = taskbo.Description;
            memoEdit10.Text = taskbo.Remark;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}