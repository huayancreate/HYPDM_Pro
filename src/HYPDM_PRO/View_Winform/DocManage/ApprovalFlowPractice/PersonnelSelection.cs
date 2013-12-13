using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.DocManage.ApprovalFlowPractice
{
    public partial class PersonnelSelection : DevExpress.XtraEditors.XtraForm
    {
        public PersonnelSelection()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }
    }
}