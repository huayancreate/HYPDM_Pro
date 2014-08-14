using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;

namespace View_Winform.MyTaskBox
{
    public partial class ChangeNotification : DevExpress.XtraEditors.XtraForm
    {
        IMyTaskBoxService mytaskboxservice;
        public ChangeNotification()
        {
            InitializeComponent();
        }

        private void ChangeNotification_Load(object sender, EventArgs e)
        {
            mytaskboxservice = WcfExtension.WcfServiceLocator.Create<IMyTaskBoxService>();
            PackageCommon.SettingGridView(gridView1);
            PackageCommon.SettingGridView(gridView2);
            PackageCommon.SettingGridView(gridView3);
            gcChangeNotification.DataSource = mytaskboxservice.GetChangeNotificationAll();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gcChangeDocument.DataSource = mytaskboxservice.GetChangeDocumentByChangeNotificationID(1);
            gcChangeStructure.DataSource = mytaskboxservice.GetChangeStructureByChangeNotificationID(1);
            mmeRemark.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
    }
}