using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using View_Winform.SystemManagementAndTools.SystemUserMessageManage;
using System.ComponentModel;
using DevExpress.XtraGrid;

namespace View_Winform.CommonTemplet
{
    public partial class paging : DevExpress.XtraEditors.XtraUserControl
    {
        public DevExpress.XtraGrid.Views.Grid.GridView gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
        
        public paging()
        {
            InitializeComponent();
        }
        
        private void SelectAll_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < gridView.RowCount; i++)
            {
               
                gridView.SetRowCellValue(i, "isChecked", true);
                

            }
        }

        private void CancelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {

                gridView.SetRowCellValue(i, "isChecked", false);


            }

        }

        
    }
}
