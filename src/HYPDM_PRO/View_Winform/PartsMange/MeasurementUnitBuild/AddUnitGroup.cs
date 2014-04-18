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
    public partial class AddUnitGroup : DevExpress.XtraEditors.XtraForm
    {
        public UnitGroup group { get; set; }
        public AddUnitGroup()
        {
            InitializeComponent();
        }

        private void AddUnitGroup_Load(object sender, EventArgs e)
        {

        }

        private void PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Cancel_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Confirm_SimpleButton_Click(object sender, EventArgs e)
        {
            bool ok = false;
            group.Id = group.Id + 1;
            group.name = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupName_TextEdit.Text;
            group.number = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupNumber_TextEdit.Text;
            group.description = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Description_TextEdit.Text;

            ok = WcfServiceLocator.Create<IMeasurementUnitBuild>().AddORUpdateUnitGroup(group);
            MessageBox.Show(ok.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}