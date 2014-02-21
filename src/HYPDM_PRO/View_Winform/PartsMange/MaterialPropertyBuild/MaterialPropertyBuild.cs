using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDM_Entity.PartsMange;
using WcfExtension;
using PDM_Services_Interface;


namespace View_Winform.PartsMange.MaterialBankManage
{
    public partial class MaterialPropertyBuild : Form
    {
        public MaterialPropertyBuild()
        {
            InitializeComponent();
        }

        private void MaterialPropertyBuild_Load(object sender, EventArgs e)
        {
            IList<Materialcs> list = new BindingList<Materialcs>();

             list = WcfServiceLocator.Create<IMaterialPropertyBuild>().Mate();

              PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.DataSource = list;

             



        }

    }
}
