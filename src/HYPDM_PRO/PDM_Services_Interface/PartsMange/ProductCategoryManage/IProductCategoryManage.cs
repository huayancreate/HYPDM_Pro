using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IProductCategoryManage
    {
        [OperationContract]
        IList<Material> product();  

        [OperationContract]
        IList<Material> QueryProductMessage(string name, string type, string status, string versions);   //查询产品信息

        [OperationContract]
        IList<ProductCategory> QueryClassify(string name);  //查询分类

        [OperationContract]
        IList<ProductCategory> ClassifyMessage(string name); //分类信息

        [OperationContract]
        bool AddClassify(string name);  //添加分类

        [OperationContract]
        bool DeleteClassify(int id);  //删除分类






    }
}
