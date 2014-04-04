using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using System.ComponentModel;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class AddProductCategory : IAddProductCategory
    {
        public IList<ProductCategory> AddProduct() 
        {
            IList<ProductCategory> AD = new BindingList<ProductCategory>();
            ProductCategory m = new ProductCategory ();
            m.name  = "测试";
            AD.Add(m);
            return AD;
        }
    }
}
