using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.PartsMange.MeasurementUnitBuild
{
    public partial class AddUnit : DevExpress.XtraEditors.XtraForm
    {
        IMeasurementUnitBuild unitService = WcfServiceLocator.Create<IMeasurementUnitBuild>();
        public Unit unit { get; set; }
        public int unitId;
        public AddUnit()
        {
            InitializeComponent();
        }
        private void AddUnit_Load(object sender, EventArgs e)
        {
            unit = unitService.GetUnitById(unitId);
            btnAddUnit.Click += AddORUpdateUnit;
            btnCancel.Click += FormClose;
            DataBind();
        }
        private void AddORUpdateUnit(object sender, EventArgs e)
        {
            unit.number = txtUnitCode.Text;
            unit.name = txtUnitName.Text;
            unit.scale = txtUnitRate.Text;
            unit.is_delete = "0";
            unit.create_date = DateTime.Now;
            unit.create_user_id = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataBind()
        {
            if (unit == null) return;
            txtUnitCode.Text = unit.number;
            txtUnitName.Text = unit.name;
            txtUnitRate.Text = unit.scale;
        }
    }
}