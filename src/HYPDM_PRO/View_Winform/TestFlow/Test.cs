using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View_Winform.TestFlow
{
    public partial class Test : Form
    {
        public Test()
        {
            HYBPMLib.FlowCommon f = new HYBPMLib.FlowCommon();
            string path = Application.ExecutablePath + ".config";
            f.LoadConfig(path);
            f.Login("zhoushengyu");
            f.CreateAndSendWork("002", null, null, "", "", 0, "");
            InitializeComponent();
        }
    }
}
