using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProductStruct;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.ProductStructureManage.BOMPropertyBuild
{
    public partial class BOMAddProperty : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtCboValue = new DataTable();
        public BOMProperty property { get; set; }
        IProductStruct structService = WcfServiceLocator.Create<IProductStruct>();
        List<BOM_ComboBox_Value> comboBoxValueList = new List<BOM_ComboBox_Value>();
        public BOMAddProperty()
        {
            InitializeComponent();
        }

        private void BOMAddProperty_Load(object sender, EventArgs e)
        {
            radioGroup1.SelectedIndexChanged += RadioSelectChange;
            if (this.Tag == "modify") BindData();
            simpleButton6.Click += new EventHandler(AddProperty);
            simpleButton4.Click += new EventHandler(AddItem);
            simpleButton3.Click += new EventHandler(DelItem);
            simpleButton2.Click += new EventHandler(SubmitItem);
            simpleButton5.Click += new EventHandler(FormClose);
        }

        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelItem(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void SubmitItem(object sender, EventArgs e)
        {
            for (int i = 0; i < dtCboValue.Rows.Count; i++)
            {
                var val = dtCboValue.Rows[i][0];
                var obj = new BOM_ComboBox_Value();
                obj.Id = i;
                obj.Value = val.ToString();
                obj.Create_Date = DateTime.Now;
                obj.Create_User_Id = 1;
                obj.Is_Delete = "0";
                obj.Extend_Id = 1;
                comboBoxValueList.Add(obj);
                structService.AddORUpdateComboBoxValue(obj);
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void RadioSelectChange(object sender, EventArgs e)
        {
            groupControl1.Visible = radioGroup1.SelectedIndex != 0;
        }

        private void AddProperty(object sender, EventArgs e)
        {
            property = new BOMProperty();
            //property.Id = 1;
            property.CN_Name = txtCnName.Text;
            property.EN_Name = txtEnName.Text;
            property.DataType = cboDataType.Text;
            property.DataLength = txtDataLength.Text;
            property.DefaultValue = txtDefaultValue.Text;
            property.InputType = radioGroup1.SelectedIndex.ToString();
            property.Required = chkRequired.Checked.ToString();
            property.Is_Delete = "0";
            property.Is_Query = "0";
            property.Width = "100";
            property.Create_Date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            property.Create_User_Id = 1;
            structService.AddORUpdatePorperty(property);
            this.DialogResult = DialogResult.OK;
        }

        private void BindData()
        {
            if (property == null) return;
            txtCnName.Text = property.CN_Name;
            txtEnName.Text = property.EN_Name;
            cboDataType.SelectedIndex = Convert.ToInt32(property.DataType);
            txtDataLength.Text = property.DataLength;
            txtDefaultValue.Text = property.DefaultValue;
            radioGroup1.SelectedIndex = Convert.ToInt32(property.InputType);
            chkRequired.Checked = Convert.ToBoolean(property.Required);
            var dt = structService.GetListToDataTable(property.Id);
            ComboBoxDataBind(dt);
        }

        private void ComboBoxDataBind(DataTable dt)
        {
            gridControl1.DataSource = dt;
            gridControl1.RefreshDataSource();
        }
    }
}