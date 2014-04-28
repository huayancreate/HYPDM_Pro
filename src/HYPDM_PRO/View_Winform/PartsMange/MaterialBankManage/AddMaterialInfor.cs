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
using System.Collections;
using System.Reflection;
using View_Winform.PartsMange.ProductCategoryManage;
using View_Winform.PartsMange.MaterialBankManage;
using PDM_Entity.ProductStruct;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class AddMaterialInfor : DevExpress.XtraEditors.XtraForm
    {
        IMaterialPropertyBuild propertyService = WcfServiceLocator.Create<IMaterialPropertyBuild>();
        public Material material { get; set; }
        IMaterialBankManage materialService = WcfServiceLocator.Create<IMaterialBankManage>();
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
        List<MaterialBaseProperty> propertyList = new List<MaterialBaseProperty>();
        public AddMaterialInfor()
        {
            InitializeComponent();
            gridView1 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView1, false);
        }
        private void PartsMange_MaterialBankManage_AddMaterialInfor_CancelMaterialMessage_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }
        private void AddMaterialInfor_Load(object sender, EventArgs e)
        {
            DesignerForm();
            simpleButton1.Click += SupplyQuotaClick;
            #region 下拉框数据绑定
            ComboBoxDataBind(PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit, 2);
            PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.SelectedIndex = 0;
            ComboBoxDataBind(PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit, 3);
            PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.SelectedIndex = 0;
            #endregion
            #region 页面数据绑定
            if (this.Tag == "Modify")
            {
                PropertyDataBind();
                PartsMange_MaterialBankManage_AddMaterialInfor_PartNumber_ButtonEdit.Text = material.No;
                PartsMange_MaterialBankManage_AddMaterialInfor_PartName_TextEdit.Text = material.Name;
                PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.Text = material.Property_Type;
                PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.Text = material.Species;
                PartsMange_MaterialBankManage_AddMaterialInfor_Weight_TextEdit.Text = material.Weight;
                PartsMange_MaterialBankManage_AddMaterialInfor_Type_TextEdit.Text = material.Property_Type;
                PartsMange_MaterialBankManage_AddMaterialInfor_BelongClassify_ButtonEdit.Text = material.Category;
                PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text = material.Product_Type;
                PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text = material.Original_No;
                PartsMange_MaterialBankManage_AddMaterialInfor_PartVersion_TextEdit.Text = material.Version;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text = material.Unit_Id;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasureGroup_TextEdit.Text = material.Unit_Group_Id;
                PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text = material.Material_Id.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_CostPrice_TextEdit.Text = material.Price;
                PartsMange_MaterialBankManage_AddMaterialInfor_Norms_TextEdit.Text = material.Standard;
                textEdit1.Text = material.Remark;
            }
            if (this.Tag == "AnalogyAdd")
            {
                PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.Text = material.Property_Type;
                PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.Text = material.Species;
                PartsMange_MaterialBankManage_AddMaterialInfor_Weight_TextEdit.Text = material.Weight;
                PartsMange_MaterialBankManage_AddMaterialInfor_Type_TextEdit.Text = material.Property_Type;
                PartsMange_MaterialBankManage_AddMaterialInfor_BelongClassify_ButtonEdit.Text = material.Category;
                PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text = material.Product_Type;
                PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text = material.Original_No;
                PartsMange_MaterialBankManage_AddMaterialInfor_PartVersion_TextEdit.Text = material.Version;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text = material.Unit_Id;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasureGroup_TextEdit.Text = material.Unit_Group_Id;
                PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text = material.Material_Id.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_CostPrice_TextEdit.Text = material.Price;
                PartsMange_MaterialBankManage_AddMaterialInfor_Norms_TextEdit.Text = material.Standard;
                textEdit1.Text = material.Remark;
                material.Id = 0;
            }
            #endregion

            SupplierDataBind();
            //PropertyDataBind();
        }
        private void PartsMange_MaterialBankManage_AddMaterialInfor_ConfirmMaterialMessage_SimpleButton_Click(object sender, EventArgs e)
        {
            #region
            //var dt = CreateDataTable();
            //var value = "";
            //foreach (var item in propertyList)
            //{
            //    if (!item.is_show) continue;
            //    if (item.input_type == "0")
            //    {
            //        var txt = (TextEdit)xtraTabPage3.Controls.Find("txt" + item.en_name, true)[0];
            //        value = txt.Text;
            //    }
            //    else
            //    {
            //        var cbo = (ComboBoxEdit)xtraTabPage3.Controls.Find("cbo" + item.en_name, true)[0];
            //        value = cbo.SelectedIndex.ToString();
            //    }
            //    var row = dt.NewRow();
            //    row["en_name"] = item.en_name;
            //    row["value"] = value;
            //    dt.Rows.Add(row);
            //}
            #endregion
            #region 基础属性赋值
            material.No = PartsMange_MaterialBankManage_AddMaterialInfor_PartNumber_ButtonEdit.Text;
            material.Name = PartsMange_MaterialBankManage_AddMaterialInfor_PartName_TextEdit.Text;
            material.Property_Type = PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.Text;
            material.Species = PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.Text;
            material.Weight = PartsMange_MaterialBankManage_AddMaterialInfor_Weight_TextEdit.Text;
            material.Property_Type = PartsMange_MaterialBankManage_AddMaterialInfor_Type_TextEdit.Text;
            material.Category = PartsMange_MaterialBankManage_AddMaterialInfor_BelongClassify_ButtonEdit.Text;
            //material.Product_Type = PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text;
            material.Original_No = PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text;
            material.Version = PartsMange_MaterialBankManage_AddMaterialInfor_PartVersion_TextEdit.Text;
            //material.Unit_Id = PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text;
            //material.Unit_Group_Id = PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasureGroup_TextEdit.Text;
            //material.Material_Id = Convert.ToInt32(PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text);
            material.Price = PartsMange_MaterialBankManage_AddMaterialInfor_CostPrice_TextEdit.Text;
            material.Standard = PartsMange_MaterialBankManage_AddMaterialInfor_Norms_TextEdit.Text;

            bool result = materialService.AddORUpdateMaterial(material);
            MessageBox.Show(result.ToString());
            #endregion
        }
        #region 设计扩展属性控件
        private void DesignerForm()
        {
            propertyList = propertyService.GetAllMaterialProperty();
            #region 创建控件
            var y = 15;
            var j = 0;
            foreach (var property in propertyList)
            {
                if (!property.is_show)
                    continue;
                if (j % 2 == 0)
                {
                    var lbl = CreateLabel(25, y, property.cn_name, property.en_name);
                    xtraTabPage3.Controls.Add(lbl);
                    if (property.input_type == "0")
                    {
                        var txt = CreateTextEdit(88, y, property.en_name);
                        xtraTabPage3.Controls.Add(txt);
                    }
                    else
                    {
                        var comboBox = CreateComboBox(88, y, property.id, property.en_name);
                        xtraTabPage3.Controls.Add(comboBox);
                    }
                }
                else
                {
                    var lbl = CreateLabel(330, y, property.cn_name, property.en_name);
                    xtraTabPage3.Controls.Add(lbl);
                    if (property.input_type == "0")
                    {
                        var txt = CreateTextEdit(395, y, property.en_name);
                        xtraTabPage3.Controls.Add(txt);
                    }
                    else
                    {
                        var comboBox = CreateComboBox(395, y, property.id, property.en_name);
                        xtraTabPage3.Controls.Add(comboBox);
                    }
                    y += 30;
                }
                j++;
            }

            #endregion
        }
        private TextEdit CreateTextEdit(int x, int y, string en_name)
        {
            var txt = new TextEdit();
            txt.Name = "txt" + en_name;
            txt.Size = new Size(180, 20);
            txt.Location = new Point(x, y - 4);
            return txt;
        }
        private LabelControl CreateLabel(int x, int y, string cn_name, string en_name)
        {
            var lbl = new LabelControl();
            lbl.Name = "lbl" + en_name;
            lbl.Text = cn_name + ":";
            lbl.Size = new Size(60, 15);
            lbl.Location = new Point(x, y);
            return lbl;
        }
        private ComboBoxEdit CreateComboBox(int x, int y, int id, string en_name)
        {
            var comboBoxValueList = propertyService.GetComboBoxValueByPropertyId(id);
            var cbo = new ComboBoxEdit();
            // 添加下拉框的值
            foreach (var boxvalue in comboBoxValueList)
            {
                cbo.Properties.Items.Add(boxvalue.Value);
            }
            cbo.Name = "cbo" + en_name;
            cbo.Size = new Size(180, 20);
            cbo.Location = new Point(x, y - 4);
            return cbo;
        }
        #endregion
        public DataTable CreateDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("en_name", typeof(string));
            dt.Columns.Add("value", typeof(string));
            return dt;
        }
        /// <summary>
        /// 下拉框数据绑定
        /// </summary>
        /// <param name="cbo">下拉框控件</param>
        /// <param name="propertyId">属性Id</param>
        private void ComboBoxDataBind(ComboBoxEdit cbo, int propertyId)
        {
            cbo.Properties.Items.Clear();
            var cboValueList = propertyService.GetComboBoxValueByPropertyId(propertyId);
            foreach (var item in cboValueList)
            {
                cbo.Properties.Items.Add(item.Value);
            }
        }
        /// <summary>
        /// 单位选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var unitForm = new MeasurementUnitBuild();
            unitForm.Tag = "choose";
            unitForm.ShowDialog();
            if (unitForm.DialogResult == DialogResult.OK)
            {
                if (unitForm.unit == null) return;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text = unitForm.unit.name;
                material.Unit_Id = unitForm.unit.id.ToString();
                material.Unit_Group_Id = unitForm.unit.unit_group_id.ToString();
            }
        }
        /// <summary>
        /// 材料选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var materialForm = new MaterialBankManage();
            materialForm.Tag = "choose";
            materialForm.ShowDialog();
            if (materialForm.DialogResult == DialogResult.OK)
            {
                if (materialForm.material == null) return;
                PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text = materialForm.material.Name;
                material.Material_Id = materialForm.material.Id;
            }
        }
        /// <summary>
        /// 产品类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var categoryForm = new ProductCategoryTreeList();
            categoryForm.ShowDialog();
            if (categoryForm.DialogResult == DialogResult.OK)
            {
                if (categoryForm.productCategory == null) return;
                PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text = categoryForm.productCategory.name;
                material.Product_Type = categoryForm.productCategory.id.ToString();
            }
        }
        /// <summary>
        /// 供应配额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupplyQuotaClick(object sender, EventArgs e)
        {
            var addSupplyQuota = new AddSupplyQuota();
            var supplierQuota = new SupplierQuota();
            supplierQuota.Supplier_Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            addSupplyQuota.supplierQuota = supplierQuota;
            addSupplyQuota.ShowDialog();
        }
        /// <summary>
        /// 供应商数据绑定
        /// </summary>
        void SupplierDataBind()
        {
            var supplierList = productStructService.GetAllSupplierList();
            gridControl1.DataSource = supplierList;
        }
        private void PropertyDataBind()
        {
            var dt = materialService.GetMaterialById(material.Id);
            #region 扩展属性赋值
            foreach (Control control in xtraTabPage3.Controls)
            {
                if (control is LabelControl) continue;
                Type type = control.GetType();
                if (type.Name.Equals("TextEdit"))
                {
                    var txt = (TextEdit)control;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        try
                        {
                            txt.Text = dt.Rows[i][txt.Name.Remove(0, 3)].ToString();
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                if (type.Name.Equals("ComboBoxEdit"))
                {
                    var cbo = (ComboBoxEdit)control;
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        try
                        {
                            cbo.SelectedIndex = Convert.ToInt32(dt.Rows[j][cbo.Name.Remove(0, 3)]);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
            //foreach (var item in propertyList)
            //{
            //    if (!item.is_show) continue;
            //    if (item.input_type == "0")
            //    {
            //        var txt = (TextEdit)xtraTabPage3.Controls.Find("txt" + item.en_name, true)[0];
            //        txt.Text = "测试数据";
            //    }
            //    else
            //    {
            //        var cbo = (ComboBoxEdit)xtraTabPage3.Controls.Find("cbo" + item.en_name, true)[0];
            //        cbo.SelectedIndex = 1;
            //    }
            //}
            #endregion
        }
    }
}