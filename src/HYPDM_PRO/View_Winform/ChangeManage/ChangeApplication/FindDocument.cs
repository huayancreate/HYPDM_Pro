using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using PDM_Entity.MyTaskBox;

namespace View_Winform.ChangeManage.ChangeApplication
{
    public partial class FindDocument : InitService
    {
        public bool m_checkStatus { get; set; }
        public FindDocument()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FindDocument_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1);
            DevGridViewCheckbox devgv = new DevGridViewCheckbox();
            devgv.SettingGridViewCheckBox(gridView1, gridColumn2);
            gridColumn3.UnboundType = UnboundColumnType.Object;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            gcDocuments.DataSource = service.getAllDocuments();
        }
        private System.Collections.Hashtable Images = new System.Collections.Hashtable();
        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            string ext = (e.Row as Document).Extension;
            if (!Images.ContainsKey(ext)){
                Image img = HYUtils.Icons.SystemIcon.GetFileIcon(ext, true).ToBitmap();
                Images.Add(ext, img);
            }
            e.Value = Images[ext];
        }

    }
}