using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProductStruct;

namespace View_Winform.ProductStructureManage.SupplierManage
{
    public partial class AddSupplier : DevExpress.XtraEditors.XtraForm
    {
        private int Id { get; set; }
        public AddSupplier()
        {
            InitializeComponent();
        }
        public AddSupplier(int id)
        {
            InitializeComponent();
            Id = id;
        }
        private void AddSupplier_Load(object sender, EventArgs e)
        {
            simpleButton2.Click += CreateSupplier;
            simpleButton1.Click += FormClose;
            DataBind();
        }
        private void CreateSupplier(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            supplier.Id = 1;
            supplier.Name = txtSupplierName.Text;
            supplier.Type = txtSupplierType.Text;
            supplier.Address = txtSupplierAddr.Text;
            supplier.Category = txtSupplierCategory.Text;
            supplier.Phone = txtSupplierPhone.Text;
            supplier.Remark = txtSupplierRemark.Text;
            supplier.WebSite = txtSupplierWebSite.Text;
            supplier.ZipCode = txtSupplierZipCode.Text;

            this.Hide();
        }
        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataBind()
        {
            var supplier = new Test.BOMData().GetSupplierById(Id);
            if (supplier == null) return;
            txtSupplierName.Text = supplier.Name;
            txtSupplierType.Text = supplier.Type;
            txtSupplierAddr.Text = supplier.Address;
            txtSupplierCategory.Text = supplier.Category;
            txtSupplierPhone.Text = supplier.Phone;
            txtSupplierRemark.Text = supplier.Remark;
            txtSupplierWebSite.Text = supplier.WebSite;
            txtSupplierZipCode.Text = supplier.ZipCode;
        }
    }
}