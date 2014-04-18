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

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class AddMaterialInfor : DevExpress.XtraEditors.XtraForm
    {
        private IMaterialPropertyBuild propertyService = WcfServiceLocator.Create<IMaterialPropertyBuild>();
        public MaterialBaseProperty MaterBase;
        public Material material { get; set; }
        List<MaterialBaseProperty> propertyList = new List<MaterialBaseProperty>();
        public AddMaterialInfor()
        {
            InitializeComponent();
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
            if (this.Tag == "Modify")
            {
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
                //WcfServiceLocator.Create<IAddMaterialInfor>().MaterialMessage(MaterBase.id);
            }
            if (this.Tag == "AnalogyAdd")
            {
                PartsMange_MaterialBankManage_AddMaterialInfor_PartNumber_ButtonEdit.Text = MaterBase.number.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_PartName_TextEdit.Text = MaterBase.en_name;
                PartsMange_MaterialBankManage_AddMaterialInfor_Property_ComboBoxEdit.Text = MaterBase.material_property_type_id.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_Variety_ComboBoxEdit.Text = MaterBase.variety;
                PartsMange_MaterialBankManage_AddMaterialInfor_Weight_TextEdit.Text = MaterBase.weight;
                PartsMange_MaterialBankManage_AddMaterialInfor_Type_TextEdit.Text = MaterBase.type;
                PartsMange_MaterialBankManage_AddMaterialInfor_BelongClassify_ButtonEdit.Text = MaterBase.belong_classify;
                PartsMange_MaterialBankManage_AddMaterialInfor_ProductType_ButtonEdit.Text = MaterBase.product_type;
                PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text = MaterBase.original_number.ToString();
                PartsMange_MaterialBankManage_AddMaterialInfor_PartVersion_TextEdit.Text = MaterBase.version;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasure_ButtonEdit.Text = MaterBase.unit_measure;
                PartsMange_MaterialBankManage_AddMaterialInfor_UnitMeasureGroup_TextEdit.Text = MaterBase.unit_measure_group;
                PartsMange_MaterialBankManage_AddMaterialInfor_Material_ButtonEdit.Text = MaterBase.material;
                PartsMange_MaterialBankManage_AddMaterialInfor_CostPrice_TextEdit.Text = MaterBase.cost_price;
                PartsMange_MaterialBankManage_AddMaterialInfor_Norms_TextEdit.Text = MaterBase.norms;
                PartsMange_MaterialBankManage_AddMaterialInfor_Remark_GroupControl.Text = MaterBase.remark;
                //WcfServiceLocator.Create<IAddMaterialInfor>().MaterialMessage(MaterBase.id);
            }
            DesignerForm();
        }
        private void PartsMange_MaterialBankManage_AddMaterialInfor_ConfirmMaterialMessage_SimpleButton_Click(object sender, EventArgs e)
        {
            #region 扩展属性赋值
            var dt = CreateDataTable();
            var value = "";
            foreach (var item in propertyList)
            {
                if (!item.is_show) continue;
                if (item.input_type == "0")
                {
                    var txt = (TextEdit)xtraTabPage3.Controls.Find("txt" + item.en_name, true)[0];
                    value = txt.Text;
                }
                else
                {
                    var cbo = (ComboBoxEdit)xtraTabPage3.Controls.Find("cbo" + item.en_name, true)[0];
                    value = cbo.SelectedIndex.ToString();
                }
                var row = dt.NewRow();
                row["en_name"] = item.en_name;
                row["value"] = value;
                dt.Rows.Add(row);
            }
            #endregion
            #region 基础属性赋值
            material.No = PartsMange_MaterialBankManage_AddMaterialInfor_PartNumber_ButtonEdit.Text;
            //material = PartsMange_MaterialBankManage_AddMaterialInfor_OriginalNumber_TextEdit.Text;
            #endregion
        }
        #region 扩展属性
        private void DesignerForm()
        {
            propertyList = propertyService.GetAllMaterialProperty();
            #region 创建控件
            var y = 15;
            var j = 0;
            for (int i = 0; i < propertyList.Count; i++)
            {
                var property = propertyList[i];
                if (!property.is_show) continue;
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
            txt.Size = new System.Drawing.Size(180, 20);
            txt.Location = new System.Drawing.Point(x, y - 4);
            return txt;
        }
        private LabelControl CreateLabel(int x, int y, string cn_name, string en_name)
        {
            var lbl = new LabelControl();
            lbl.Name = "lbl" + en_name;
            lbl.Text = cn_name + ":";
            lbl.Size = new System.Drawing.Size(60, 15);
            lbl.Location = new System.Drawing.Point(x, y);
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
            cbo.Size = new System.Drawing.Size(180, 20);
            cbo.Location = new System.Drawing.Point(x, y - 4);
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
    }
}