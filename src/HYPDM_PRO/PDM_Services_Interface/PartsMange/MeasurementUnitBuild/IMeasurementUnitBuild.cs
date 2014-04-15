using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface

{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMeasurementUnitBuild
    {
        [OperationContract]
        IList<Unit> list1(); //单位信息

        [OperationContract]
        IList<UnitGroup> list2();  //单位组信息

        [OperationContract]
        bool AddUnitGroup(int id); //添加计量单位组
    }
}

