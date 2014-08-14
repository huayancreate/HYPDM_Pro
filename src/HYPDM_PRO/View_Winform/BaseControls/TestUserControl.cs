using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.BaseControls
{
    public partial class TestUserControl : UserControl
    {
        public int _id;
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
        public TestUserControl()
        {
            InitializeComponent();
        }
        public TestUserControl(int id)
        {
            InitializeComponent();
            _id = id;
            BindData();
        }

        private void BindData()
        {
            //基础属性
            if (_id == 0) return;
            var m = GetMaterial(_id);
            MaterialDataLoad(m);
            //BOM节点附加信息
            //文档清单
            //版本信息
            //零部件文档清单
            //零部件引用列表
            //零部件列表
        }

        private void MaterialDataLoad(Material m)
        {
            if (m == null) return;
            //DesignerForm(m.Material_Type_Id);
            txtMaterialNo.Text = m.No;
            txtMaterialName.Text = m.Name;
            txtMaterialVersion.Text = m.Version;
            txtOriginalNo.Text = m.Original_No;
            foreach (var item in cboSpecies.Properties.Items)
            {
                var speciesItem = (ComboBoxData)item;
                if (speciesItem.Value == m.Species)
                {
                    cboSpecies.SelectedItem = speciesItem;
                }
            }
            foreach (var item in cboProperty.Properties.Items)
            {
                var propertyItem = (ComboBoxData)item;
                if (propertyItem.Value == m.Property_Type)
                {
                    cboProperty.SelectedItem = propertyItem;
                }
            }
            //var unit = unitservice.GetUnitById(Convert.ToInt32(m.Unit_Id));
            //if (unit != null)
            //{
            //    btnUnit.Text = unit.name;
            //    var unitgroup = unitservice.GetUnitGroupById(unit.unit_group_id);
            //    if (unitgroup != null)
            //    {
            //        txtUnitGroup.Text = unitgroup.name;
            //    }
            //}
            txtgg.Text = m.Standard;
            txtModel.Text = m.Model_No;

            //var material = materialService.GetMaterialById(m.Material_Id);
            //if (material.Rows.Count > 0)
            //    btnStuff.Text = material.Rows[0]["Name"].ToString();

            txtWeight.Text = m.Weight;
            txtStatus.Text = m.Status;

            //var productcategory = productCategoryService.GetProductByCategoryId(Convert.ToInt32(m.Category));
            //if (productcategory.Rows.Count > 0)
            //    cboProduct.Text = productcategory.Rows[0]["CategoryName"].ToString();

            //var materialtype = materialService.GetMaterialTypeById(m.Material_Type_Id);
            //if (materialtype != null)
            //    cboCategory.Text = materialtype.Name;
        }

        private Material GetMaterial(int id)
        {
            var m = new Test.BOMData().GetMaterialById(id); //productStructService.GetMaterialById(id);
            return m;
        }
    }
}
