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

namespace View_Winform.PartsMange
{
    public partial class ChooseMaterialType : DevExpress.XtraEditors.XtraForm
    {
        public MaterialType MT;
        public ChooseMaterialType()
        {
            InitializeComponent();
        }

        private void PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void MaterialType_Add_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaterialType m = new MaterialType();
            

        }
    }
}