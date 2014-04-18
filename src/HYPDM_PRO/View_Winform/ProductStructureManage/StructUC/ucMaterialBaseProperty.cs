using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.PartsMange;

namespace View_Winform.ProductStructureManage.StructUC
{
    public partial class ucMaterialBaseProperty : DevExpress.XtraEditors.XtraUserControl
    {
        private int _materialId { get; set; }
        public ucMaterialBaseProperty()
        {
            InitializeComponent();
        }
        public ucMaterialBaseProperty(int materialId)
        {
            InitializeComponent();
            _materialId = materialId;
        }

        private void ucMaterialBaseProperty_Load(object sender, EventArgs e)
        {
            if (_materialId == 0) return;
            MaterialDataLoad(_materialId);
        }

        private void MaterialDataLoad(int materialId)
        {
            var m = new Test.BOMData().GetMaterialById(materialId);
            if (m == null) return;
            txtMaterialNo.Text = m.No;
            txtMaterialName.Text = m.Name;
            txtMaterialVersion.Text = m.Version;
        }
    }
}
