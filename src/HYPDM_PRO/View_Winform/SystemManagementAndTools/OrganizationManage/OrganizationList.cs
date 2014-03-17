using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Services_Interface;
using PDM_Entity.SystemManagementAndTools;

namespace View_Winform.SystemManagementAndTools.OrganizationManage
{
    public partial class OrganizationList : DevExpress.XtraEditors.XtraForm
    {
        public OrganizationList()
        {
            InitializeComponent();
        }

       private void OrganizationList_Load(object sender, EventArgs e)
       {
           SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.DataSource = WcfServiceLocator.Create<IOrganizationManage>().findOrganization("");
       }
       
        
     
    }
}