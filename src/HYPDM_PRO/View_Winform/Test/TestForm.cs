using PDM_Services_Interface;
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
                Console.WriteLine(ex.Message);
            }
        }

        private void cal_Click(object sender, EventArgs e)
        {
            try
            {
                double name = WcfServiceLocator.Create<ITestService2>().Add2(2.2, 2.1);
                MessageBox.Show(name.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PDM_Entity.SystemManagementAndTools.Group group = WcfServiceLocator.Create<IUserGroupManage>().getAllGroups(1, "", "");
                MessageBox.Show(group.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
