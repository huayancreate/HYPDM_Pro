using DevExpress.XtraEditors;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WcfExtension;
using System.Threading;
using System.Reflection;
using View_Winform.BaseControls;

namespace View_Winform.Test
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private IMaterialPropertyBuild propertyService = WcfServiceLocator.Create<IMaterialPropertyBuild>();
        public Form1()
        {
            InitializeComponent();
            TestUserControl control = new TestUserControl(1);
            control.Location = new Point(491, 65);
            this.Controls.Add(control);
            //testUserControl1.TestUserControl();
            //DesignerForm();
        }
        private void DesignerForm1()
        {
            var propertyList = propertyService.GetAllMaterialProperty();
            var text = propertyList[0].GetType().GetProperties();
            int Location_y = 10;
            for (int i = 0; i < propertyList.Count; i++)
            {
                var property = propertyList[i];
                //if (!property.is_show) continue;
                if (i % 2 == 0)
                {
                    // 为第一列
                    var lbl = new LabelControl();
                    lbl.Name = "lbl" + property.en_name;
                    lbl.Text = property.cn_name + ":";
                    lbl.Size = new System.Drawing.Size(60, 15);
                    lbl.Location = new System.Drawing.Point(25, Location_y);
                    this.Controls.Add(lbl);
                    if (property.input_type == "1")
                    {
                        var comboBoxValueList = propertyService.GetComboBoxValueByPropertyId(property.id);
                        var cbo = new ComboBoxEdit();
                        // 添加下拉框的值
                        foreach (var boxvalue in comboBoxValueList)
                        {
                            cbo.Properties.Items.Add(boxvalue.Value);
                        }
                        cbo.Name = property.en_name;
                        cbo.Size = new System.Drawing.Size(280, 20);
                        cbo.Location = new System.Drawing.Point(88, Location_y - 4);
                        this.Controls.Add(cbo);
                    }
                    else
                    {
                        var txt = new TextEdit();
                        txt.Name = "txt" + property.en_name;
                        txt.Size = new System.Drawing.Size(280, 20);
                        txt.Location = new System.Drawing.Point(88, Location_y - 4);
                        this.Controls.Add(txt);
                    }
                }
                else
                {
                    // 为第二列
                    var lbl = new LabelControl();
                    lbl.Name = "lbl" + property.en_name;
                    lbl.Text = property.cn_name + ":";
                    lbl.Size = new System.Drawing.Size(60, 15);
                    lbl.Location = new System.Drawing.Point(412, Location_y);
                    this.Controls.Add(lbl);
                    if (property.input_type == "1")
                    {
                        var comboBoxValueList = propertyService.GetComboBoxValueByPropertyId(property.id);
                        var cbo = new ComboBoxEdit();
                        // 添加下拉框的值
                        foreach (var boxvalue in comboBoxValueList)
                        {
                            cbo.Properties.Items.Add(boxvalue.Value);
                        }
                        cbo.Name = property.en_name;
                        cbo.Size = new System.Drawing.Size(280, 20);
                        cbo.Location = new System.Drawing.Point(88, Location_y - 4);
                        this.Controls.Add(cbo);
                    }
                    else
                    {
                        var txt = new TextEdit();
                        txt.Name = "txt" + property.en_name;
                        txt.Size = new System.Drawing.Size(264, 20);
                        txt.Location = new System.Drawing.Point(480, Location_y - 4);
                        this.Controls.Add(txt);
                    }
                    Location_y = Location_y + 30;
                }
            }
        }

        private void DesignerForm()
        {
            var propertyList = propertyService.GetAllMaterialProperty();
            #region 创建控件
            var y = 10;
            for (int i = 0; i < propertyList.Count; i++)
            {
                var property = propertyList[i];
                if (i % 2 == 0)
                {
                    var lbl = CreateLabel(25, y, property.cn_name, property.en_name);
                    this.Controls.Add(lbl);
                    if (property.input_type == "0")
                    {
                        var txt = CreateTextEdit(88, y, property.en_name);
                        this.Controls.Add(txt);
                    }
                    else
                    {
                        var comboBox = CreateComboBox(88, y, property.id, property.en_name);
                        this.Controls.Add(comboBox);
                    }
                }
                else
                {
                    var lbl = CreateLabel(412, y, property.cn_name, property.en_name);
                    this.Controls.Add(lbl);
                    if (property.input_type == "0")
                    {
                        var txt = CreateTextEdit(480, y, property.en_name);
                        this.Controls.Add(txt);
                    }
                    else
                    {
                        var comboBox = CreateComboBox(88, y, property.id, property.en_name);
                        this.Controls.Add(comboBox);
                    }
                    y += 30;
                }
            }

            #endregion
        }

        private TextEdit CreateTextEdit(int x, int y, string en_name)
        {
            var txt = new TextEdit();
            txt.Name = "txt" + en_name;
            txt.Size = new System.Drawing.Size(264, 20);
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
            cbo.Name = en_name;
            cbo.Size = new System.Drawing.Size(280, 20);
            cbo.Location = new System.Drawing.Point(x, y - 4);
            return cbo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.DataSource = CreateTable();
            comboBoxEdit1.Properties.DisplayMember = "Name1";
            comboBoxEdit1.Properties.ValueMember = "Id1";
            //var propertyList = propertyService.GetAllMaterialProperty();
            //DesignerForm();
        }

        private DataTable CreateTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("Name1");
            dt.Columns.Add("Id1");
            var row = dt.NewRow();
            row["Name1"] = "test1";
            row["Id1"] = 1;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Name1"] = "test2";
            row["Id1"] = 2;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Name1"] = "test3";
            row["Id1"] = 3;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Name1"] = "test4";
            row["Id1"] = 4;
            dt.Rows.Add(row);
            return dt;
        }

    }
}
