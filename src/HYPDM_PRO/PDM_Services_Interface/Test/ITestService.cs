using PDM_Entity.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace PDM_Services_Interface.Test
{
    [ServiceContract(Namespace = "PDM_Services_Interface.Test")]
    public interface ITestService
    {
        [OperationContract]
        User GetUser(string name, int age);
    }
}
