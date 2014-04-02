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
        public BOM_Attached_Property property;
        private List<BOM_ComboBox_Value> _list = new List<BOM_ComboBox_Value>();
        public BOMAddProperty()
        {
            InitializeComponent();
        }

        private void BOMAddProperty_Load(object sender, EventArgs e)
        {
            if (this.Tag == "edit") BindData();

            radioGroup1.SelectedIndexChanged += new EventHandler(RadioChang);
            simpleButton6.Click += new EventHandler(AddProperty);
            simpleButton4.Click += new EventHandler(AddItem);
            simpleButton3.Click += new EventHandler(DelItem);
            simpleButton2.Click += new EventHandler(SubmitItem);
            simpleButton5.Click += new EventHandler(FormClose);
            dtCboValue.Columns.Add("Value", typeof(string));
            gridControl1.DataSource = dtCboValue;
            groupControl1.Visible = false;
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
                //WcfServiceLocator.Create<IProjectStruct>().AddORUpdateComboBoxValue(obj);
                _list.Add(obj);
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void RadioChang(object sender, EventArgs e)
        {
			groupControl1.Visible = radioGroup1.SelectedIndex != 0;
        }

        private void AddProperty(object sender, EventArgs e)
        {
            property = new BOM_Attached_Property();
            property.Id = 1;
            property.CN_Name = txtCnName.Text;
            property.EN_Name = txtEnName.Text;
            property.DataType = cboDataType.Text;
            property.DataLength = txtDataLength.Text;
            property.DefaultValue = cboDefaultVal.Text;
            property.InputType = radioGroup1.SelectedIndex.ToString();
            property.Required = chkRequired.Checked.ToString();
            property.Is_Delete = "0";
            property.Is_Query = "0";
            property.Width = "100";
            property.Create_Date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            property.Create_User_Id = 1;
            //WcfServiceLocator.Create<IProjectStruct>().AddORUpdatePorperty(property);
            this.DialogResult = DialogResult.OK;
        }

        private void BindData()
        {
            txtCnName.Text = property.CN_Name;
            //property.Id = 1;
            //property.CN_Name = txtCnName.Text;
            //property.EN_Name = txtEnName.Text;
            //property.DataType = cboDataType.Text;
            //property.DataLength = txtDataLength.Text;
            //property.DefaultValue = cboDefaultVal.Text;
            //property.InputType = radioGroup1.SelectedIndex.ToString();
            //property.Required = chkRequired.Checked.ToString();
            //property.Is_Delete = "0";
            //property.Is_Query = "0";
            //property.Width = "100";
            //property.Create_Date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            //property.Create_User_Id = 1;
            //this.DialogResult = DialogResult.OK;
        }

        private void ComboBoxDataBind()
        {
            cboDataType.Properties.Items.Add("1");
        }
    }
}