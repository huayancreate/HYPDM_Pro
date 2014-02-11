using PDM_Services_Interface.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WcfExtension;

namespace View_Winform.Test
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = WcfServiceLocator.Create<ITestService>().GetUser("zhuye", 28).Name;
                MessageBox.Show(name);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
