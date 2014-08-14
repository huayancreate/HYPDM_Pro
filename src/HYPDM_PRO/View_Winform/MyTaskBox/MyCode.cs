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

namespace View_Winform.MyTaskBox
{
    public partial class MyCode : DevExpress.XtraEditors.XtraForm
    {
        IMyTaskBoxService mytaskboxservice;
        public MyCode()
        {
            InitializeComponent();
        }
        private void MyCode_Load(object sender, EventArgs e)
        {
            mytaskboxservice = WcfExtension.WcfServiceLocator.Create<IMyTaskBoxService>();
            PackageCommon.SettingGridView(gridView1);
            PackageCommon.SettingGridView(gridView2);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            Hashtable condition = new Hashtable();
            gcCodeApplication.DataSource = mytaskboxservice.GetCodesByConditions(condition);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (MouseButtons.Right == e.Button) {
                popupMenu1.ShowPopup(e.Location);
            }
        }

        private void bbiAppliaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var applycode = new ApplyCode();
            applycode.ShowDialog();
        }


    }
}