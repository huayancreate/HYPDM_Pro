using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.DocManage.DocManageTool
{
    public partial class ChooseDocTemplate : DevExpress.XtraEditors.XtraForm
    {
        public ChooseDocTemplate()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void ChooseDocTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}