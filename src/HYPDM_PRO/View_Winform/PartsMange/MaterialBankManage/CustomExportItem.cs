using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class CustomExportItem : Form
    {
        public CustomExportItem()
        {
            InitializeComponent();
        }

        private void simpleButton6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Close();
            }
        }
    }
}
