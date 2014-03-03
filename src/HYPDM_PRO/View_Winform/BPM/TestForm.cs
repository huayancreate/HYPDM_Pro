using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BP.WF;

namespace View_Winform.BPM
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {
        public TestForm()
        {
            InitializeComponent();
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
    }
}