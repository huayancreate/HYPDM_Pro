using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using PDM_Entity.ProductStruct;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Entity.DocManage;
using System.Data;
using System.Reflection;
using System.Collections;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ProductStruct : IProductStruct
    {
        #region BOM相关操作
        public bool AddORUpdateBOM(BOM bom)
        {
            var sql = new StringBuilder();
            if (bom.Id == 0)
            {
                sql.Clear();
                //添加
                sql.AppendLine("insert into bom (name,number,parent_id,belong_task,type,status,is_delete,description,version)");
                sql.AppendLine("values ('" + bom.Name + "','" + bom.Number + "','" + bom.Parent_Id + "','" + bom.Belong_Task + "',");
                sql.AppendLine("'" + bom.Type + "','" + bom.Status + "','" + bom.Is_Delete + "','" + bom.Description + "','" + bom.Version + "'");
                return true;
            }
            else
            {
                //修改
                sql.Clear();
                sql.AppendLine("update bom set name='" + bom.Name + "',number='" + bom.Number + "',parent_id=" + bom.Parent_Id + ",");
                sql.AppendLine("belong_task='" + bom.Belong_Task + "',type='" + bom.Type + "',status='" + bom.Status + "',is_delete='" + bom.Is_Delete + "',");
                sql.AppendLine("description='" + bom.Description + "',version='" + bom.Version + "' where id=" + bom.Id + "");
                return false;
            }
        }
        public List<BOM> GetAllBOMList()
        {
            var sql = "select * from bom where is_delete='0'";
            return new Test.BOMData().GetAllBOM();
        }
        public List<BOM> GetBOMListBySql(string strsql)
        {
            List<BOM> _list = new List<BOM>();
            var sql = "select * from bom where " + strsql + "";
            return _list;
        }
        public bool DeleteBOM(int id)
        {
            var sql = "update bom set is_delete='1' where id=" + id + "";
            return true;
        }

        public BOM GetBOMById(int bomId)
        {
            return new Test.BOMData().GetBOMById(bomId);
            //throw new NotImplementedException();
        }
        public List<BOMDto> GetAllBOMDtoList()
        {
            return new Test.BOMData().GetAllBOMDto();
        }
        #endregion
        #region BOM结构相关操作
        /// <summary>
        /// 根据bomId获取BOM结构数据
        /// </summary>
        /// <param name="bomId"></param>
        /// <returns></returns>
        public List<BOM_Struct> GetBOMStructListByBOMId(int bomId)
        {
            var sql = "select * from bom_struct where bom_id=" + bomId + " and is_delete='0'";
            return new Test.BOMData().GetAllStructByBOMId(bomId);
        }
        /// <summary>
        /// 根据bomId和materialId获取BOM结构数据
        /// </summary>
        /// <param name="materialId"></param>
        /// <param name="bomId"></param>
        /// <returns></returns>
        public List<BOM_Struct> GetBOMStructListByMaterialId(int materialId, int bomId)
        {
            var sql = "select * from bom_struct where material_id=" + materialId + " and bom_id=" + bomId + " and is_delete='0'";
            return new Test.BOMData().GetStructListByMaterialId(materialId, bomId);
        }
        /// <summary>
        /// 根据id和bomId获取BOM结构数据
        /// </summary>/
        /// <param name="id"></param>vv
        /// <param name="bomId"></param>
        /// <returns></returns>
        public List<BOM_Struct> GetBOMStructListByParentId(int id, int bomId)
        {
            var sql = "select * from bom_struct where parent_id=" + id + " and bom_id=" + bomId + " and is_delete='0'";

            var structList = new Test.BOMData().GetAllStruct().FindAll(s => s.Id == id);
            //structList.Add(GetBOMStructListByMaterialId)
            GetAllChildBOMStruct(id, ref structList);
            return structList;
            //return new Test.BOMData().GetStructListByParentId(id, bomId);
        }
        /// <summary>
        /// 根据BOM结构列表添加结构数据
        /// </summary>
        /// <param name="structList"></param>
        /// <returns></returns>
        public bool AddBOMStructWithList(List<BOM_Struct> structList)
        {
            if (structList.Count > 0)
            {
                foreach (var s in structList)
                {
                    AddBOMStruct(s);
                }
            }
            return true;
        }
        /// <summary>
        /// 添加BOM结构数据
        /// </summary>
        /// <param name="bomStruct"></param>
        /// <returns></returns>
        public bool AddBOMStruct(BOM_Struct bomStruct)
        {
            var sql = "insert into bom_struct(bom_id,material_id,parent_id) values(" + bomStruct.BOM_Id + "," + bomStruct.Material_Id + "," + bomStruct.Parent_Id + ")";
            return false;
        }
        public bool UpdateBOMStruct(BOM_Struct bomStruct)
        {
            var sql = "Update bom_struct set bom_id=" + bomStruct.BOM_Id + ",material_id=" + bomStruct.Material_Id + ",parent_id=" + bomStruct.Parent_Id + " where id=" + bomStruct.Id + "";
            return false;
        }
        public BOM_Struct GetBOMStructByMaterialId(int materialId, int bomId)
        {
            var list = new Test.BOMData().GetStructListByMaterialId(materialId, bomId);
            if (list.Count > 0)
                return list[0];
            return null;
        }
        /// <summary>
        /// 根据父节点获取所有子节点数据
        /// </summary>
        /// <param name="id">父节点</param>
        /// <param name="strucList">返回的集合</param>
        private void GetAllChildBOMStruct(int id, ref List<BOM_Struct> strucList)
        {
            var list = new Test.BOMData().GetAllStruct().FindAll(s => s.Parent_Id == id);
            foreach (var s in list)
            {
                strucList.Add(s);
                GetAllChildBOMStruct(s.Id, ref strucList);
            }
        }
        #endregion
        #region 供应商相关操作
        public bool AddORUpdateSupplier(Supplier supplier)
        {
            var sql = new StringBuilder();
            if (supplier.Id != 0)
            {
                //更新
                sql.AppendLine("update supplier set name='" + supplier.Name + "',type='" + supplier.Type + "',category='" + supplier.Category + "'");
                sql.AppendLine(",website='" + supplier.WebSite + "',zipcode='" + supplier.ZipCode + "',address='" + supplier.Address + "'");
                sql.AppendLine(",remark='" + supplier.Remark + "',phone='" + supplier.Phone + "' where id=" + supplier.Id + "");

            }
            else
            {
                //新增
                sql.AppendLine("insert into supplier(name,type,category,website,zipcode,address,remark,phone) values (");
                sql.AppendLine("'" + supplier.Name + "','" + supplier.Type + "','" + supplier.Category + "','" + supplier.WebSite + "'");
                sql.AppendLine(",'" + supplier.ZipCode + "','" + supplier.Address + "','" + supplier.Remark + "','" + supplier.Phone + "')");
            }
            return false;
        }
        public List<Supplier> GetAllSupplierList()
        {
            //var supplierList = new List<Supplier>();
            return new Test.BOMData().GetAllSupplier();
        }
        #endregion
        #region 物料相关操作
        public Material GetMaterialById(int id)
        {
            return new MaterialBankManage().GetAllMaterial().Find(m => m.Id == id);
            //return new Test.BOMData().GetMaterialById(id);
        }
        public List<DocumentDto> GetDocWithMaterailByMaterialId(int id)
        {
            var docMaterialList = new Test.BOMData().GetDocPartsByPartId(id);
            var docList = new Test.BOMData().GetAllDocumentDto();
            return docMaterialList.Select(doc_m => docList.Find(doc => doc.Id == doc_m.Doc_Id)).ToList();
        }


        public List<Material> GetAllMaterialList(int id, int bomId)
        {
            var materialList = new List<Material>();
            var structList = GetBOMStructListByParentId(id, bomId);
            foreach (var item in structList)
            {
                materialList.Add(GetMaterialById(item.Material_Id));
            }
            return materialList;
        }
        #endregion
        #region 属性相关操作
        public List<BOMProperty> GetAllBOMProperty()
        {
            var propertyList = new List<BOMProperty>();

            string sql = "select * from bom_base_property union select * from bom_attached_property";

            var baseProperty = new BOMProperty
            {
                CN_Name = "轴承",
                EN_Name = "zhoucheng",
                DataType = "1",
                DataLength = "20",
                DefaultValue = "是",
                Width = "54px",
                Required = "true",
                Id = 1,
                InputType = "1",
                Is_Show = true,
                PropertyType = "基础属性"
            };
            propertyList.Add(baseProperty);

            baseProperty = new BOMProperty
            {
                CN_Name = "轮胎",
                EN_Name = "luntai",
                DataType = "0",
                DataLength = "100",
                DefaultValue = "是",
                Width = "100px",
                Is_Show = true,
                InputType = "0",
                Required = "false",
                Id = 2,
                PropertyType = "自定义属性"
            };
            propertyList.Add(baseProperty);

            baseProperty = new BOMProperty
            {
                CN_Name = "自行车",
                EN_Name = "bike",
                Required = "false",
                DataType = "0",
                DataLength = "100",
                DefaultValue = "是",
                Width = "100px",
                Id = 3,
                Is_Show = true,
                InputType = "1",
                PropertyType = "自定义属性"
            };
            propertyList.Add(baseProperty);

            baseProperty = new BOMProperty
            {
                CN_Name = "骑车",
                EN_Name = "qiche",
                Required = "true",
                DataType = "0",
                DataLength = "100",
                DefaultValue = "是",
                Width = "100px",
                Id = 4,
                Is_Show = true,
                InputType = "0",
                PropertyType = "BOM自定义属性"
            };
            propertyList.Add(baseProperty);

            return propertyList;
        }

        public bool AddORUpdatePorperty(BOMProperty property)
        {
            return property.Id == 0 ? AddProperty(property) : UpdateProperty(property);
        }

        public bool AddORUpdateComboBoxValue(BOM_ComboBox_Value value)
        {
            return value.Id == 0 ? AddComboBoxValue(value) : UpdateComboBoxValue(value);
        }

        public List<BOM_ComboBox_Value> GetListByPropertyId(int propertyId)
        {
            return null;
        }

        public bool DeleteComboBoxValue(int propertyId)
        {
            return true;
        }

        public bool DeleteProperty(int propertyId)
        {
            return true;
        }

        private bool AddProperty(BOMProperty property)
        {
            //在BOM表中动态创建名称为en_name值的字段名称
            return true;
        }


        private bool UpdateProperty(BOMProperty property)
        {
            return false;
        }

        private bool AddComboBoxValue(BOM_ComboBox_Value value)
        {
            return false;
        }

        private bool UpdateComboBoxValue(BOM_ComboBox_Value value)
        {
            return true;
        }

        public DataTable GetListToDataTable(int propertyId)
        {
            return ToDataTable(GetComboBoxValueByPropertyId(propertyId), "comboBoxValue");
        }

        public List<BOM_ComboBox_Value> GetComboBoxValueByPropertyId(int propertyId)
        {
            return GetAllComboBoxValue().FindAll(c => c.Extend_Id == propertyId);
        }

        private List<BOM_ComboBox_Value> GetAllComboBoxValue()
        {
            var comboBoxValueList = new List<BOM_ComboBox_Value>();
            var comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 1,
                Extend_Id = 1,
                Value = "测试1",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);

            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 2,
                Extend_Id = 1,
                Value = "测试2",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);

            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 3,
                Extend_Id = 1,
                Value = "测试3",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);

            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 4,
                Extend_Id = 1,
                Value = "测试4",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            #region 物料属性
            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 5,
                Extend_Id = 2,
                Value = "外协件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 6,
                Extend_Id = 2,
                Value = "自制件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 7,
                Extend_Id = 2,
                Value = "外购件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 8,
                Extend_Id = 2,
                Value = "虚拟件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            #endregion
            #region 物料种类
            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 9,
                Extend_Id = 3,
                Value = "零件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 10,
                Extend_Id = 3,
                Value = "部件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new BOM_ComboBox_Value
            {
                Id = 11,
                Extend_Id = 3,
                Value = "产品",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            #endregion
            return comboBoxValueList;
        }
        /// <summary>
        /// 泛型集合转换成DataTable
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public DataTable ToDataTable(IList list, string tableName)
        {
            if (list.Count == 0) return null;
            DataTable result = new DataTable(tableName);
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }
        #endregion
    }
}
