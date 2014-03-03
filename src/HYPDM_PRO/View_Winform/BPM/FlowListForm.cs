using BP.Web;
using BP.WF;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View_Winform.BPM
{
    public partial class FlowListForm : DevExpress.XtraEditors.XtraForm
    {
        public FlowListForm()
        {
            InitializeComponent();
            FormLoad();
        }

        private void FormLoad()
        {
            var dataTable = Dev2Interface.DB_GenerCanStartFlowsOfDataTable(WebUser.No);
            gcFlowControl.DataSource = dataTable;
            RepositoryItemHyperLinkEdit repHyperLink = new RepositoryItemHyperLinkEdit();
            gcFlowControl.RepositoryItems.Add(repHyperLink);
            gvFlow.Columns["Map"].ColumnEdit = repHyperLink;
            repHyperLink.LinkColor = Color.Maroon;
            repHyperLink.NullText = "查看";
        }

        private void gvFlow_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var url = "";
            var baseUrl = BP.SystemConfig.AppSettings["BaseUrl"];
            var flow_id = gvFlow.GetRowCellValue(e.RowHandle, gvFlow.Columns["No"]);
            if (e.Column.FieldName.Equals("Map"))
            {
                //this.Hide();
                url = baseUrl + "/WF/Chart.aspx?FK_Flow=" + flow_id + "&DoType=Chart";
            }
            else
            {

                if (e.Button == MouseButtons.Left)
                {
                    if (!gvFlow.IsGroupRow(e.RowHandle))
                    {
                        long workid = BP.WF.Dev2Interface.Node_CreateStartNodeWork(flow_id.ToString(), null, null, WebUser.No, null, 0, null);
                        Work currWork = BP.WF.Dev2Interface.Flow_GetCurrentWork(workid);
                        url = baseUrl + "/WF/MyFlowSmall.aspx?FK_Flow=" + flow_id + "&FK_Node=" + currWork.NodeID + "&userNo=" + BP.Web.WebUser.No + "";
                    }
                }
            }
            FlowBrowserForm f = new FlowBrowserForm(url);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Tag = "start";
            f.ShowDialog();
        }
    }
}
