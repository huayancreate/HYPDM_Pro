using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDM_Services_Interface;
using PDM_Entity.PartsMange;
using WcfExtension;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class MaterialPegging : Form
    {
        public string ans = "";
        public MaterialPegging()
        {
            InitializeComponent();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void MaterialPegging_Load(object sender, EventArgs e)
        {
            IList<Material> M = new BindingList<Material>();
            M = WcfServiceLocator.Create<IMaterialPegging>().MP();
            PartsMange_MaterialPegging_MaterialPegging_PartList_GridControl.DataSource = M;
            //PartsMange_MaterialPegging_MaterialPegging_MaterialPegging1_ComboBoxEdit.DataBindings.Add("type",Tag,"1");
            //PartsMange_MaterialPegging_MaterialPegging_MaterialPegging1_ComboBoxEdit.Properties.Items.Add(Tag);
            //PartsMange_MaterialPegging_MaterialPegging_MaterialPegging1_ComboBoxEdit.DataBindings.ToString() = "type";
            //PartsMange_MaterialPegging_MaterialPegging_MaterialPegging2_ComboBoxEdit.DataBindings.ToString() = "versions";
            //PartsMange_MaterialPegging_MaterialPegging_MaterialPegging3_ComboBoxEdit.DataBindings.ToString() = "status";

             
            IList<Material> Ma = new BindingList<Material>();
            Ma = WcfServiceLocator.Create<IMaterialPegging>().MB();
            PartsMange_MaterialPegging_MaterialPegging_ProjectBOMList_GridControl.DataSource = Ma;


            IList<Material> Mb = new BindingList<Material>();
            Mb = WcfServiceLocator.Create<IMaterialPegging>().WB();
            PartsMange_MaterialPegging_MaterialPegging_WorkBOMList_GridControl.DataSource = Mb;


            IList<Material> Mc = new BindingList<Material>();
            Mc = WcfServiceLocator.Create<IMaterialPegging>().WP();
            PartsMange_MaterialPegging_MaterialPegging_WorkBOMPartList_GridControl.DataSource = Mc;


            IList<Material> Md = new BindingList<Material>();
            Md = WcfServiceLocator.Create<IMaterialPegging>().AW();
            PartsMange_MaterialPegging_MaterialPegging_AssembleWorkList_GridControl.DataSource = Md;


            IList<Material> Me = new BindingList<Material>();
            Me = WcfServiceLocator.Create<IMaterialPegging>().AP();
            PartsMange_MaterialPegging_MaterialPegging_AssembleWorkPartList_GridControl.DataSource = Me;
        }

        private void PartsMange_MaterialPegging_MaterialPegging_Output_SimpleButton_Click(object sender, EventArgs e)
        {
            CustomExportItem CE = new CustomExportItem();
            CE.Show();
        }

        private void PartsMange_MaterialPegging_MaterialPegging_WorkBOMOutput_SimpleButton_Click(object sender, EventArgs e)
        {
            CustomExportItem CE = new CustomExportItem();
            CE.Show();
        }

        private void PartsMange_MaterialPegging_MaterialPegging_AssembleWorkOutput_SimpleButton_Click(object sender, EventArgs e)
        {
            CustomExportItem CE = new CustomExportItem();
            CE.Show();
        }

        private void PartsMange_MaterialPegging_MaterialPegging_Pegging_SimpleButton_Click(object sender, EventArgs e)
        {
            string type = PartsMange_MaterialPegging_MaterialPegging_MaterialPegging1_ComboBoxEdit.Tag.ToString();
            string versions = PartsMange_MaterialPegging_MaterialPegging_MaterialPegging2_ComboBoxEdit.Tag.ToString();
            string status = PartsMange_MaterialPegging_MaterialPegging_MaterialPegging3_ComboBoxEdit.Tag.ToString();


            PartsMange_MaterialPegging_MaterialPegging_PartList_GridControl.DataSource = 
                WcfServiceLocator.Create<IMaterialPegging>().ProjectBOMPegging();

            PartsMange_MaterialPegging_MaterialPegging_WorkBOMPartList_GridControl.DataSource = 
                WcfServiceLocator.Create<IMaterialPegging>().WorkBOMPegging();

            PartsMange_MaterialPegging_MaterialPegging_AssembleWorkPartList_GridControl.DataSource = 
                WcfServiceLocator.Create<IMaterialPegging>().AssembleWorkPegging();
        }

        public void RadioButton() 
        {
            if (PartsMange_MaterialPegging_MaterialPegging_AndMaterialPegging_CheckEdit.Checked == true)
            {
                ans = PartsMange_MaterialPegging_MaterialPegging_AndMaterialPegging_CheckEdit.Text;
            }
            else if (PartsMange_MaterialPegging_MaterialPegging_OrMaterialPegging_CheckEdit.Checked == true)
            {
                ans = PartsMange_MaterialPegging_MaterialPegging_OrMaterialPegging_CheckEdit.Text;
            }
           

        }

        private void PartsMange_MaterialPegging_MaterialPegging_AndMaterialPegging_CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton R = sender as RadioButton;
            if (R.Checked == true) 
            {
                ans = R.Text;
                MessageBox.Show(ans);
            }
        }
    }

}
