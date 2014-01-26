using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.ProjectManage.ProjectPlanManage
{
    public partial class ProjectList : DevExpress.XtraEditors.XtraForm
    {
        public ProjectList()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void ProjectList_Load(object sender, EventArgs e)
        {

        }
    }
}