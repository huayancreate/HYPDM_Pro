using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.ProjectManage.ProjectFlowDefinition
{
    public partial class ProjectInputCatalogManage : DevExpress.XtraEditors.XtraForm
    {
        public ProjectInputCatalogManage()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }
    }
}