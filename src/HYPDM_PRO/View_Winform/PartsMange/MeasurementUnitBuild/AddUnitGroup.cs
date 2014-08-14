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
        public int groupId;
        public UnitGroup group { get; set; }
        public AddUnitGroup()
        {
            InitializeComponent();
        }

        private void AddUnitGroup_Load(object sender, EventArgs e)
        {
            if (this.Tag == "Edit")
            {
                var unitGroup = WcfServiceLocator.Create<IMeasurementUnitBuild>().GetUnitGroupById(groupId);
                PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupNumber_TextEdit.Text = unitGroup.number;
                PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupName_TextEdit.Text = unitGroup.name;
                PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Description_TextEdit.Text = unitGroup.description;
            }
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
            if (this.Tag == "Edit")
                group = WcfServiceLocator.Create<IMeasurementUnitBuild>().GetUnitGroupById(groupId);
            else
                group = new UnitGroup();
            group.name = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupName_TextEdit.Text;
            group.number = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupNumber_TextEdit.Text;
            group.description = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Description_TextEdit.Text;

            WcfServiceLocator.Create<IMeasurementUnitBuild>().AddORUpdateUnitGroup(group);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}