using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace View_Winform.ProductStructureManage.SupplierManage
{
    public partial class SupplierManage : DevExpress.XtraEditors.XtraForm
    {
        private int Id { get; set; }
        public SupplierManage()
        {
            InitializeComponent();
            gridView1 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView1, false);//new BaseControls.BaseGridViewControl().BaseGridViewControlSetting(gridView1, false);
        }
        private void SupplierManage_Load(object sender, EventArgs e)
        {
            simpleButton5.Click += QuerySupplier;
            simpleButton4.Click += AddSupplier;
            simpleButton3.Click += EditSupplier;
            simpleButton2.Click += DeleteSupplier;
            simpleButton2.Click += FormClose;
            DataBind();
        }
        private void QuerySupplier(object sender, EventArgs e)
        {

        }
        private void AddSupplier(object sender, EventArgs e)
        {
            var addSupplieForm = new AddSupplier();
            addSupplieForm.ShowDialog();
        }
        private void EditSupplier(object sender, EventArgs e)
        {
            var id = gridView1.GetFocusedRowCellValue(gridColumn8);
            var addSupplieForm = new AddSupplier(Convert.ToInt32(id));
            addSupplieForm.Text = "编辑供应商";
            addSupplieForm.ShowDialog();
        }
        private void DeleteSupplier(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            var id = gv.GetFocusedRowCellValue("Id");
            MessageBox.Show("删除的值为：" + id.ToString());
        }
        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataBind()
        {
            var supplierList = new Test.BOMData().GetAllSupplier();
            gridControl1.DataSource = supplierList;
        }
    }
}