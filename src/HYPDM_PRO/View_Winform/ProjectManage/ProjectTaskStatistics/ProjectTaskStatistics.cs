using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using WcfExtension;
using PDM_Services_Interface;
using System.Collections;
using DevExpress.XtraCharts.Native;

namespace View_Winform.ProjectManage.ProjectTaskStatistics
{
    public partial class ProjectTaskStatistics : DevExpress.XtraEditors.XtraForm
    {
        //XYDiagram xyDiagram1 = new XYDiagram();
        public ProjectTaskStatistics()
        {
            InitializeComponent();
        }

        private void ProjectTaskStatistics_Load(object sender, EventArgs e)
        {
            var points = ccTaskStatisticalFigure.Series[0].Points;
            points.Add(new SeriesPoint("就绪", 0));
            points.Add(new SeriesPoint("执行", 0));
            points.Add(new SeriesPoint("完成", 0));
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            meStatisticalConditions.Text = "项目所属组:\r\n\t所有\r\n人员:\r\n\t所有\r\n时间:\r\n\t所有";
            var attr = new Hashtable();
            var taskAnalyzeList = WcfServiceLocator.Create<IProjectTaskStatisticsService>().getTasksAnalyze(attr);
            gcOrderStatistics.DataSource = taskAnalyzeList;
            var points = ccTaskStatisticalFigure.Series[0].Points;
            points.Clear();
            foreach (var taskAnalyze in taskAnalyzeList)
            {
                points.Add(new SeriesPoint(taskAnalyze.State, taskAnalyze.Count));

            }
        }

        private void cmbChooseChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbChooseChart.SelectedIndex)
            {
                case 0:
                    {
                        var shape = new SideBySideBarSeriesView();
                        ccTaskStatisticalFigure.Series[0].View = shape;
                    } break;
                case 1:
                    {
                        var shape = new PieSeriesView();
                        var label = ccTaskStatisticalFigure.Series[0].Label;
                        var pointOptions = label.PointOptions;
                        pointOptions.PointView = PointView.ArgumentAndValues;
                        pointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
                        ccTaskStatisticalFigure.Series[0].View = shape;
                    } break;
                case 2:
                    {
                        var shape = new LineSeriesView();
                        ccTaskStatisticalFigure.Series[0].View = shape;
                    } break;
                case 3:
                    {
                        var shape = new AreaSeriesView();
                        shape.Transparency = (byte)135;
                        ccTaskStatisticalFigure.Series[0].View = shape;
                    } break;
            }
        }
    }
}