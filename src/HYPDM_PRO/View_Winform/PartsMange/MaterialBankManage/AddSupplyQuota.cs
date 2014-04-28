using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProductStruct;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.PartsMange.MaterialBankManage
{
    public partial class AddSupplyQuota : DevExpress.XtraEditors.XtraForm
    {
        public SupplierQuota supplierQuota { get; set; }
        IProductStruct structService = WcfServiceLocator.Create<IProductStruct>();
        public AddSupplyQuota()
        {
            InitializeComponent();
        }

        private void AddSupplyQuota_Load(object sender, EventArgs e)
        {
            simpleButton1.Click += AddSupplyQuotaClick;
            simpleButton2.Click += FormClose;
            if (supplierQuota == null) return;
            var supplier = structService.GetAllSupplierList().Find(s => s.Id == supplierQuota.Supplier_Id);
            if (supplier == null) return;
            txtSupplierName.Text = supplier.Name;
        }

        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSupplyQuotaClick(object sender, EventArgs e)
        {
            supplierQuota.Id = 1;
            supplierQuota.Amount = txtAmount.Text;
            supplierQuota.Is_Delete = "0";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
