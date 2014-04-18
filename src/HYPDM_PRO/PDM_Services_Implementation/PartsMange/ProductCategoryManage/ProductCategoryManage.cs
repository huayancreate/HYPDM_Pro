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
    public class ProductCategoryManage : IProductCategoryManage
    {
        public IList<Material> product()
        {
            IList<Material> p = new BindingList<Material>();
            Material m = new Material();
            Material m1 = new Material();
            Material m2 = new Material();

            //m.cn_name = "去年买了个表";
            //m.number = "1001";
            //m.status = "设计";
            //m.type = "通用";

            //m1.cn_name = "快到碗里来";
            //m1.number = "1002";
            //m1.status = "外购";
            //m1.type = "外协";

            //m2.cn_name = "打酱油";
            //m2.number = "1003";
            //m2.status = "外购";
            //m2.type = "通用";

            //p.Add(m);
            //p.Add(m1);
            //p.Add(m2);
            return p;
        }

        public IList<Material> QueryProductMessage(string type, string name, string status, string versions)
        {
            IList<Material> m = new BindingList<Material>();
            Material material = new Material();
            return m;
        }

        public IList<ProductCategory> ClassifyMessage(string name)
        {
            IList<ProductCategory> P = new BindingList<ProductCategory>();
            ProductCategory p = new ProductCategory();
            ProductCategory p1 = new ProductCategory();
            ProductCategory p2 = new ProductCategory();

            p.name = "波音";
            p.parent_id = 20011;
            p.modify_user_id = 2001;
            p.create_user_id = 1001;

            p1.name = "空客";
            p1.parent_id = 20002;
            p1.modify_user_id = 2002;
            p1.create_user_id = 1002;

            p2.name = "洛克希德.马丁";
            p2.parent_id = 20002;
            p2.modify_user_id = 2002;
            p2.create_user_id = 1002;

            return P;

        }

        public bool AddClassify(string name)
        {

            return true;
        }

        public IList<ProductCategory> QueryClassify(string name)
        {
            IList<ProductCategory> PC = new BindingList<ProductCategory>();
            ProductCategory p = new ProductCategory();
            ProductCategory p1 = new ProductCategory();
            ProductCategory p2 = new ProductCategory();
            ProductCategory p3 = new ProductCategory();

            p.name = "地球";
            p1.name = "火星";
            p2.name = "月球";
            p3.name = "太阳";

            PC.Add(p);
            PC.Add(p1);
            PC.Add(p2);
            PC.Add(p3);

            return PC;
        }

        public bool DeleteClassify(int id)
        {
            return true;
        }
    }

}
