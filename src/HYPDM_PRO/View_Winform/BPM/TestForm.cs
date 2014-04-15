using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BP.WF;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace View_Winform.BPM
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {
        public TestForm()
        {
            InitializeComponent();
            GridColumn unbColumn = gridView1.Columns.AddField("Total");
            unbColumn.VisibleIndex = gridView1.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridControl1.DataSource = new Test.BOMData().GetAllBOM();
        }

        /// <summary>
        /// 获取流程状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            HYBPMLib.FlowCommon common = new HYBPMLib.FlowCommon();
            var c = (int)WFState.Complete;
            var state = common.WF_State("002", 350);
        }
        int i = 0;

        string getTotalValue(GridView view, int listSourceRowIndex)
        {
            return "123456";
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //MessageBox.Show(e.DisplayText);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            MessageBox.Show(e.Handled.ToString());
        }
    }
}