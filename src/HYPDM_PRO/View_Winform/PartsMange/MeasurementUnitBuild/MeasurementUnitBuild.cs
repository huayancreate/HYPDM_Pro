using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using PDM_Entity.PartsMange;
using WcfExtension;
using View_Winform.PartsMange.MeasurementUnitBuild;


namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class MeasurementUnitBuild : DevExpress.XtraEditors.XtraForm
    {
        public UnitGroup UG;
        public MeasurementUnitBuild()
        {
            InitializeComponent();
        }

        private void MeasurementUnitBuild_Load(object sender, EventArgs e)
        {
            IList<Unit> U = new BindingList<Unit>();
            U = WcfServiceLocator.Create<IMeasurementUnitBuild>().list1();
            PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitMeasurement_GridControl.DataSource = U;
            

            IList<UnitGroup> UG = new BindingList<UnitGroup>();
            UG = WcfServiceLocator.Create<IMeasurementUnitBuild>().list2();
            PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitMeasurementGropu_GridControl.DataSource = UG;
        }

        private void PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitMeasurementAndGropu_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None)) 
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void TreeList_Add_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUnitGroup Aun = new AddUnitGroup();
            Aun.Show();
        }

        private void TreeList_Modify_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}