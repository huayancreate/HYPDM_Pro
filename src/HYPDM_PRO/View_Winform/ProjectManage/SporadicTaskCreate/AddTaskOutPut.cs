using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProjectManage;

namespace View_Winform.ProjectManage.SporadicTaskCreate
{

    public partial class AddTaskOutput : DevExpress.XtraEditors.XtraForm
    {
        public List<OutputInformationbo> ParentForm_OutputInformations { get; set; }//零星任务输出信息列表
        List<OutputInformationbo> outputInformations { get; set; }//零星任务输出信息列表
        OutputInformationbo outputInformation { get; set; }
        public AddTaskOutput()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加任务文档包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTaskDocumentPackage_Click(object sender, EventArgs e)
        {
            var createdocumentpackage = new CreateDocumentPackage();
            createdocumentpackage.ShowDialog();
            if (createdocumentpackage.outputinformation != null)
            {
                outputInformations.Add(createdocumentpackage.outputinformation);
                gcOutputInformation.DataSource = outputInformations;
                gcOutputInformation.RefreshDataSource();
            }
        }
        /// <summary>
        /// 添加零部件设计包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPartDesignPackage_Click(object sender, EventArgs e)
        {
            var partsdesignpackage = new AddPartsDesignPackage();
            partsdesignpackage.ShowDialog();
            if (partsdesignpackage.outputInformation != null)
            {
                outputInformations.Add(partsdesignpackage.outputInformation);
                gcOutputInformation.DataSource = outputInformations;
                gcOutputInformation.RefreshDataSource();
            }
        }
        /// <summary>
        /// 添加产品结构配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProductStructureConfiguration_Click(object sender, EventArgs e)
        {
            var createproductdeploy = new CreateProductDeploy();
            createproductdeploy.ShowDialog();
            if (createproductdeploy.outputInformation != null)
            {
                outputInformations.Add(createproductdeploy.outputInformation);
                gcOutputInformation.DataSource = outputInformations;
                gcOutputInformation.RefreshDataSource();
            }
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTaskOutPut_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1, false);
            PackageCommon.SettingGridView(gridView2, false);
            outputInformations = new List<OutputInformationbo>();
            foreach (OutputInformationbo o in ParentForm_OutputInformations)
            {
                outputInformations.Add(o);
            }
            gcOutputInformation.DataSource = outputInformations;
            gcOutputInformation.RefreshDataSource();
        }
        /// <summary>
        /// 复制归档BOM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyBom_Click(object sender, EventArgs e)
        {
            var copyPigeoholeBom = new CopyArchiveBOM();
            copyPigeoholeBom.ShowDialog();
            if (copyPigeoholeBom.outputInformation != null)
            {
                outputInformations.Add(copyPigeoholeBom.outputInformation);
                gcOutputInformation.DataSource = outputInformations;
                gcOutputInformation.RefreshDataSource();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (OutputInformationbo o in outputInformations)
            {
                if (!ParentForm_OutputInformations.Contains(o)) ParentForm_OutputInformations.Add(o);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}