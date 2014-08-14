using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Entity;
using System.ServiceModel;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IHyPdmMainService
    {
        /// <summary>
        /// 获取主菜单,获取主界面主菜单树形结构
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<HyPdmMenu> getHuayanPdmMainMenu();
    }
}
