using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.SystemManagementAndTools.UserManage
{
    public partial class RoleManage : DevExpress.XtraEditors.XtraForm
    {
        public RoleManage()
        {
            InitializeComponent();
        }

        private void treeList2_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }
    }
}