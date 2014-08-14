using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDM_Services_Interface;
using System.Collections;

namespace View_Winform.MyTaskBox
{
    public partial class MyDocument : Form
    {
        IMyTaskBoxService mytaskboxservice;
        public MyDocument()
        {
            InitializeComponent();
        }

        private void MyDocument_Load(object sender, EventArgs e)
        {
            mytaskboxservice = WcfExtension.WcfServiceLocator.Create<IMyTaskBoxService>();
            groupControl1.Text = "共查询出0条符合条件的有效数据";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var conditions = new Hashtable();
            gcDocuments.DataSource = mytaskboxservice.GetMyDocumentByConditions(conditions);
        }
    }
}
