using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IAddReviewRule
    {
        [OperationContract]
        string Save(int id);

        [OperationContract]
        bool DeleteReviewProperty(int id);


    }
}
