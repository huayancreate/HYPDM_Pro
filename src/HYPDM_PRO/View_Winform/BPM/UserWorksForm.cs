using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HYBPMLib;
using System.Runtime.InteropServices;
using BP.DA;
using DevExpress.XtraGrid.Views.Grid;

namespace View_Winform.BPM
{
    public partial class UserWorksForm : DevExpress.XtraEditors.XtraForm
    {
        public UserWorksForm()
        {
            InitializeComponent();
            gvFlow.OptionsBehavior.Editable = false;
            FormLoad();
        }

        private void FormLoad()
        {
            FlowCommon common = new FlowCommon();
            gcFlowControl.DataSource = common.GetEmpWorks();

        }

        private void gvFlow_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var baseUrl = BP.SystemConfig.AppSettings["BaseUrl"];
            if (e.Button == MouseButtons.Left)
            {
                //this.Hide();
                var flow_id = gvFlow.GetRowCellValue(e.RowHandle, gvFlow.Columns["FK_Flow"]);
                var work_id = gvFlow.GetRowCellValue(e.RowHandle, gvFlow.Columns["WorkID"]);
                var node_id = gvFlow.GetRowCellValue(e.RowHandle, gvFlow.Columns["FK_Node"]);
                BP.WF.Node n = new BP.WF.Node(node_id.ToString());
                var url = "";
                if (n.IsStartNode)
                {
                    url = baseUrl + "/WF/MyFlowSmall.aspx?FK_Flow=" + flow_id + "&FK_Node=" + node_id + "&userNo=" + BP.Web.WebUser.No + "";
                }
                else
                {
                    url = baseUrl + "/WF/MyFlowSmall.aspx?FK_Flow=" + flow_id + "&FK_Node=" + node_id + "&FID=0&WorkID=" + work_id + "&IsRead=0&userNo=" + BP.Web.WebUser.No + "";
                }
                FlowBrowserForm f = new FlowBrowserForm(url);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Tag = "process";
                f.ShowDialog();
            }
        }

        private void gvFlow_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column.Equals(Status))
            {
                DateTime cdt = DateTime.Now;
                var sdt = gvFlow.GetRowCellValue(e.RowHandle, gvFlow.Columns["SDT"]);
                DateTime mysdt = DataType.ParseSysDate2DateTime(sdt.ToString());
                if (cdt >= mysdt)
                {
                    if (cdt.ToString("yyyy-MM-dd") == mysdt.ToString("yyyy-MM-dd"))
                    {
                        e.DisplayText = "正常";
                    }
                    else
                    {
                        e.DisplayText = "逾期";
                    }
                }
            }
        }
    }
}