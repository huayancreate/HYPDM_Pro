using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProjectManage;
using System.IO;

namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    public partial class AddTaskInput : DevExpress.XtraEditors.XtraForm
    {
        public List<InputInformationbo> ParentFormInputInformations { get; set; }
        public List<InputInformationbo> inputInformations { get; set; }
        public AddTaskInput()
        {
            InitializeComponent();
        }

        private void btnAddExternalDocument_Click(object sender, EventArgs e)
        {
            string filename = "";
            var openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var inputinfo = new InputInformationbo();
                filename = openfile.FileName;
                inputInformations.Add(new InputInformationbo()
                {
                    Filename = Path.GetFileName(filename),
                    Pathname = Path.GetFullPath(filename),
                    Format = Path.GetExtension(filename),
                    Name = filename,
                    Type = "外部文档"
                });
                gcInputInformation.DataSource = inputInformations;
                gcInputInformation.RefreshDataSource();
            }
        }

        private void AddTaskInput_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1, false);
            PackageCommon.SettingGridView(gridView2, false);
            inputInformations = new List<InputInformationbo>();
            foreach (InputInformationbo o in ParentFormInputInformations)
            {
                inputInformations.Add(o);
            }
            gcInputInformation.DataSource = inputInformations;
            gcInputInformation.RefreshDataSource();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (InputInformationbo o in inputInformations)
            {
                if (!ParentFormInputInformations.Contains(o))
                    ParentFormInputInformations.Add(o);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}