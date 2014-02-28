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
        public ConmmonListBoxControl()
        {
            InitializeComponent();
            listBoxControl1.Text = value;
        }
    }
}
