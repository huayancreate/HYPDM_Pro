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
using System.Threading;
using DevExpress.XtraGrid.Columns;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraCharts;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace View_Winform.ProjectManage.ProjectPlanManage
{
    public partial class GanttChart : DevExpress.XtraEditors.XtraForm
    {
        public GanttChart()
        {
            InitializeComponent();
        }
        TreeListNode focused;
        private void GanttChart_Load(object sender, EventArgs e)
        {
            List<TaskTree> tasktree = WcfServiceLocator.Create<IProjectPlanManageService>().getTaskTree();
            tlTaskTree.DataSource = tasktree;
            tlTaskTree.ParentFieldName = "ParentName";
            tlTaskTree.KeyFieldName = "Name";
            tlTaskTree.ExpandAll();
            DateTime[] projectDate = WcfServiceLocator.Create<IProjectPlanManageService>().getGanttCalendar(1);
            initGantt(tasktree, projectDate);
        }

        void initGantt(List<TaskTree> tasktree,DateTime[] projectDate)
        {
            BandedGridView view = advBandedGridView1 as BandedGridView;
            view.BeginUpdate(); //开始视图的编辑，防止触发其他事件
            view.BeginDataUpdate(); //开始数据的编辑
            view.Bands.Clear();
            DateTime start = new DateTime(2013, 12, 10);
            DateTime end = new DateTime(2014, 5, 2);
            GridBand gridBand = view.Bands.AddBand(start.ToString("yy-MM-dd"));
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            int days = (end - start).Days;
            string Day = "日一二三四五六";
            CustomAxisLabel[] customaxislabels = new CustomAxisLabel[days + 1];
            customaxislabels[0] = new CustomAxisLabel(start.ToString("yy-MM-dd"), start);
            for (int i = 0; i <= days + 1; i++)
            {
                try
                {
                    CustomAxisLabel cal = new CustomAxisLabel();
                    cal.AxisValue = start;
                    cal.Name = start.ToString("yy-MM-dd");
                    customaxislabels[i + 1] = cal;
                    if (start.DayOfWeek == DayOfWeek.Monday)
                    {
                        gridBand = view.Bands.AddBand(start.ToString("yyyy-MM-dd"));
                        gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    }
                    GridBand childen = gridBand.Children.AddBand(Day[(int)start.DayOfWeek] + "");
                    childen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    childen.Width = 24;
                    start = start.AddDays(1);
                }
                catch { }
            }
            gcGanttDate.Width = days * 24 + 2;
            view.EndDataUpdate();//结束数据的编辑
            view.EndUpdate();   //结束视图的编辑

            //设置甘特图属性
            ccProjectGantt.Width = gcGanttDate.Width;
            //chartControl1.Height = 4 * 24;
            ganttDiagram1.AxisX.Visible = false;
            ganttDiagram1.AxisY.CustomLabels.AddRange(customaxislabels);
            ConstantLine progress = new ConstantLine("当前进度", DateTime.Now);
            progress.Color = Color.Red;
            ganttDiagram1.AxisY.ConstantLines.Add(progress);
            ganttDiagram1.AxisY.Range.MinValueInternal = 0;
            ganttDiagram1.AxisY.Range.MaxValueInternal = days * 24;
            ganttDiagram1.AxisY.Visible = false;

            series1.Points.Add(new SeriesPoint("项目进度", new DateTime[] { new DateTime(2013, 12, 12, 0, 0, 0), new DateTime(2014, 4, 30) }));
            SeriesPoint sp = new SeriesPoint();
            series2.Points.Add(new SeriesPoint("产品进度", new DateTime[] { new DateTime(2013, 12, 12), new DateTime(2014, 1, 12) }));
            series2.Points.Add(new SeriesPoint("Task 2", new DateTime[] { new DateTime(2014, 1, 13), new DateTime(2014, 2, 28) }));
            series2.Points.Add(new SeriesPoint("Task 3", new DateTime[] { new DateTime(2014, 3, 1), new DateTime(2014, 3, 30) }));
            series2.Points.Add(new SeriesPoint("Task 4", new DateTime[] { new DateTime(2014, 4, 1), new DateTime(2014, 4, 30) }));
            series2.Points[2].Relations.Add(series2.Points[1]);
            series3.Points.Add(new SeriesPoint("产品进度", new DateTime[] { new DateTime(2013, 12, 12), new DateTime(2014, 1, 12) }));
            series3.Points.Add(new SeriesPoint("Task 2", new DateTime[] { new DateTime(2014, 1, 13), new DateTime(2014, 2, 28) }));
            series3.Points.Add(new SeriesPoint("Task 3", new DateTime[] { new DateTime(2014, 3, 1), new DateTime(2014, 3, 4) }));
            series4.Points.Add(new SeriesPoint("Task 3", new DateTime[] { new DateTime(2014, 3, 4), DateTime.Now }));
        }

        private void ccProjectGantt_ObjectHotTracked(object sender, HotTrackEventArgs e)
        {
            //if (e.HitInfo.SeriesPoint != null)
            //{
            //    DateTime time = e.HitInfo.SeriesPoint.DateTimeValues[0];
            //    toolTipController1.ShowHint(e.HitInfo.SeriesPoint.Argument, Form.MousePosition);
            //}
            //else
            //{
            //    toolTipController1.HideHint();
            //}
        }

        private void tlTaskTree_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right){
                DevExpress.XtraTreeList.TreeListHitInfo hitInfo = (sender as DevExpress.XtraTreeList.TreeList).CalcHitInfo(new Point(e.X, e.Y));
                tlTaskTree.Selection.Set(hitInfo.Node);
                tlTaskTree.FocusedNode = hitInfo.Node;
                focused = hitInfo.Node;
                string type = hitInfo.Node.GetDisplayText("Type");
                initPopupMenu(type);
                if (hitInfo.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell&&!type.Equals("J"))
                    popupMenu1.ShowPopup(barManager1,Control.MousePosition);
            }
        }
        private void initPopupMenu(string type) {
            string typeName = "";
            switch (type)
            {
                case "J": typeName = "项目"; break;
                case "D": typeName = "产品"; break;
                case "C": typeName = "任务"; break;
                case "T": typeName = "任务"; break;
                case "A": typeName = "任务"; break;
            }
            foreach (BarItemLink bil in popupMenu1.ItemLinks)
            {
                bil.Reset();
                bil.Caption = bil.Caption.Replace("{type}", typeName);
            }
        }
        /// <summary>
        /// 查看产品/任务,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (focused.GetDisplayText("Type").Equals("D"))
            {
                ProductViewer productviewer = new ProductViewer();
                productviewer.ShowDialog();
            }
            else
            {
                //任务查看窗体
            }
        }

        private void itemModify_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (focused.GetDisplayText("Type").Equals("D"))
            {
                CreateProductDeploy deploy = new CreateProductDeploy();
                deploy.projectid = Convert.ToInt32(focused.GetDisplayText("Id"));
                deploy.ShowDialog();
            }
            else
            {
                //任务查看窗体
            }
        }

        private void itemAnalysis_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaskResolve resolve = new TaskResolve();
            resolve.projectid = Convert.ToInt32(focused.GetDisplayText("Id"));
            resolve.ShowDialog();
        }
    }
}