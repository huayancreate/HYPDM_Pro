using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProductStruct;

namespace View_Winform.ProductStructureManage.BOMPropertyBuild
{
    public partial class BOMPropertyBuild : DevExpress.XtraEditors.XtraForm
    {
        List<BOM_Attached_Property> _list = new List<BOM_Attached_Property>();
        public BOMPropertyBuild()
        {
            InitializeComponent();
        }

        private void BOMPropertyBuild_Load(object sender, EventArgs e)
        {
            simpleButton5.Click += new EventHandler(AddProperty);
            simpleButton11.Click += new EventHandler(EditProperty);
            RefreshData();
        }

        private void EditProperty(object sender, EventArgs e)
        {
            var _id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
            BOMAddProperty propertyForm = new BOMAddProperty();
            propertyForm.property = _list.Find(delegate(BOM_Attached_Property pro)
            {
                if (pro.Id == Convert.ToInt32(_id)) return true;
                return false;
            });
            propertyForm.Tag = "edit";
            propertyForm.ShowDialog();
        }

        private void AddProperty(object sender, EventArgs e)
        { 
            BOMAddProperty propertyForm = new BOMAddProperty();
            propertyForm.ShowDialog();
            if (propertyForm.DialogResult == DialogResult.OK)
            {
                _list.Add(propertyForm.property);
            }
            gridControl1.RefreshDataSource();
        }

        private void RefreshData()
        {
            gridControl1.DataSource = _list;
        }

    }
}