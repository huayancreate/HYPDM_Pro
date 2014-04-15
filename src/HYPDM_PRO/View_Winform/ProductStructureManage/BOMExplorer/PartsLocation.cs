using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.ProductStructureManage.BOMExplorer
{
    public partial class PartsLocation : DevExpress.XtraEditors.XtraForm
    {
        public int _id;
        public PartsLocation()
        {
            InitializeComponent();
        }

        private void PartsLocation_Load(object sender, EventArgs e)
        {
            BindData();
            simpleButton2.Click += new EventHandler(LocationClick);
            simpleButton1.Click += new EventHandler(FormClose);
            gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(GridViewRowClick);
        }

        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _id = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "Id"));
            _id = 2;
        }

        private void LocationClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void BindData()
        {
            gridControl1.DataSource = new Test.BOMData().GetAllMaterial();
        }
    }
}