using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.SystemManagementAndTools.OrganizationManage
{
    public partial class AddUserMessage : DevExpress.XtraEditors.XtraForm
    {
        public AddUserMessage()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }
    }
}