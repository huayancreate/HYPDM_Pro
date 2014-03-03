using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.CommonTemplet
{
    public partial class ConmmonListBoxControl : DevExpress.XtraEditors.XtraUserControl
    {
        public String value { get;set ;}
        public String controlText { get; set; }
        List<String>item = new List<String>();
        public ConmmonListBoxControl()
        {
            InitializeComponent();
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            if (value != null)
            {
                listBoxControl1.Items.Add(value);
            }
            if(controlText!=null)
            {
                groupControl1.Text=controlText;
            }
        }
    }
}
