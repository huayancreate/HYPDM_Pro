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
        public AddUnitGroup()
        {
            InitializeComponent();
        }

        private void AddUnitGroup_Load(object sender, EventArgs e)
        {

        }

        private void PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Cancel_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Confirm_SimpleButton_Click(object sender, EventArgs e)
        {
            UnitGroup UG = new UnitGroup();
            bool ok = false;

            UG.name = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupName_TextEdit.Text;
            UG.number = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitGroupNumber_TextEdit.Text;
            UG.description = PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_Description_TextEdit.Text;

            ok = WcfServiceLocator.Create<IAddUnitGroup>().SaveUnitGroup(UG);
            MessageBox.Show(ok.ToString());
             
        }

        
    }
}