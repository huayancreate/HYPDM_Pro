using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using System.Collections;

namespace View_Winform.ChangeManage.ChangeTaskManage
{
    public partial class ChangeTaskManage : InitService
    {

        public ChangeTaskManage()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var attr = new Hashtable();
            gcChangeApplication.DataSource = service.GetChangeApplicatioinByCondition(attr);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gcChangeDocument.DataSource = service.GetChangeDocumentsByChangeApplicationID(1);
            gcChangeStructure.DataSource = service.GetChangeStructureByChangeApplicationID(1);
        }
    }
}