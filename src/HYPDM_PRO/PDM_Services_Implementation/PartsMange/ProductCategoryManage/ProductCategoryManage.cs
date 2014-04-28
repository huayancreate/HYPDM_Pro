using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using System.ComponentModel;
using System.Data;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class ProductCategoryManage : IProductCategoryManage
    {
        public bool AddORUpdateCategory(ProductCategory category)
        {
            return category.id == 0 ? AddCategory(category) : UpdateCategory(category);
        }

        public List<ProductCategory> GetAllProductCategory()
        {
            var categoryList = new List<ProductCategory>();
            var category = new ProductCategory();
            category.id = 1;
            category.name = "测试数据1";
            category.parent_id = 0;
            category.is_delete = "0";
            categoryList.Add(category);

            category = new ProductCategory();
            category.id = 2;
            category.name = "测试数据2";
            category.parent_id = 1;
            category.is_delete = "0";
            categoryList.Add(category);

            category = new ProductCategory();
            category.id = 3;
            category.name = "测试数据3";
            category.parent_id = 0;
            category.is_delete = "0";
            categoryList.Add(category);

            category = new ProductCategory();
            category.id = 4;
            category.name = "测试数据4";
            category.parent_id = 3;
            category.is_delete = "0";
            categoryList.Add(category);
            return categoryList;
        }

        public bool DeleteCategory(int id)
        {
            return false;
        }

        private bool AddCategory(ProductCategory category)
        {
            return false;
        }

        private bool UpdateCategory(ProductCategory category)
        {
            return false;
        }

        public DataTable GetProductByCategoryId(int categoryId)
        {
            var dt = new DataTable("ProductCategory");
            dt.Columns.Add("Number");
            dt.Columns.Add("Version");
            dt.Columns.Add("OriginalNumber");
            dt.Columns.Add("Name");
            dt.Columns.Add("Status");
            dt.Columns.Add("CategoryName");

            var row = dt.NewRow();
            row["Number"] = "20140424";
            row["Version"] = "1.0";
            row["OriginalNumber"] = "000001";
            row["Name"] = "测试数据1";
            row["Status"] = "设计状态";
            row["CategoryName"] = "德国";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Number"] = "20140425";
            row["Version"] = "1.1";
            row["OriginalNumber"] = "000002";
            row["Name"] = "测试数据2";
            row["Status"] = "设计状态";
            row["CategoryName"] = "美国";
            dt.Rows.Add(row);

            return dt;
        }
    }
}
