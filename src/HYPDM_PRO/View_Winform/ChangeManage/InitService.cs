using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;

namespace View_Winform.ChangeManage
{
    public class InitService : DevExpress.XtraEditors.XtraForm
    {
        protected IChangeManagementService service;
        public InitService() {
            service = WcfExtension.WcfServiceLocator.Create<IChangeManagementService>();
        }
    }
}
