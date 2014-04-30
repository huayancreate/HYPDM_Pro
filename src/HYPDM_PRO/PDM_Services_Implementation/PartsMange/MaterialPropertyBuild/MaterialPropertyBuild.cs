using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Services_Interface;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Reflection;


namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]

    public class MaterialPropertyBuild : IMaterialPropertyBuild
    {
        /// <summary>
        /// 获取所有物料属性集合[基础属性和附加属性]
        /// </summary>
        /// <returns></returns>
        public List<MaterialBaseProperty> GetAllMaterialProperty()
        {
            var propertyList = new List<MaterialBaseProperty>();
            string sql = "select * from material_base_property union select * from material_attached_property";

            var baseProperty = new MaterialBaseProperty
            {
                cn_name = "轴承",
                en_name = "zhoucheng",
                data_type = "1",
                data_length = "20",
                default_value = "是",
                is_extends = "true",
                material_property_type_id = 1,
                width = "54px",
                required = "true",
                id = 1,
                input_type = "1",
                is_show = true,
                property_type = "物料基本属性"
            };
            propertyList.Add(baseProperty);

            baseProperty = new MaterialBaseProperty
            {
                cn_name = "轮胎",
                en_name = "luntai",
                data_type = "0",
                data_length = "100",
                default_value = "是",
                is_extends = "false",
                material_property_type_id = 2,
                width = "100px",
                is_show = true,
                input_type = "0",
                required = "false",
                id = 2,
                property_type = "BOM自定义属性"
            };
            propertyList.Add(baseProperty);

            baseProperty = new MaterialBaseProperty
            {
                cn_name = "自行车",
                en_name = "bike",
                required = "false",
                data_type = "0",
                data_length = "100",
                default_value = "是",
                is_extends = "false",
                material_property_type_id = 2,
                width = "100px",
                id = 3,
                is_show = true,
                input_type = "1",
                property_type = "BOM自定义属性"
            };
            propertyList.Add(baseProperty);

            baseProperty = new MaterialBaseProperty
            {
                cn_name = "骑车",
                en_name = "qiche",
                required = "true",
                data_type = "0",
                data_length = "100",
                default_value = "是",
                is_extends = "false",
                material_property_type_id = 2,
                width = "100px",
                id = 4,
                is_show = true,
                input_type = "0",
                property_type = "BOM自定义属性"
            };
            propertyList.Add(baseProperty);

            return propertyList;
        }
        public bool UpdatePropertyWithTable(string table, Dictionary<string, object> columns, int id)
        {
            var str = new StringBuilder();
            if (columns.Count <= 0) return false;
            str.Append("update " + table + " set ");
            foreach (var item in columns)
            {
                if (item.Value is bool)
                    str.Append("" + item.Key + " = " + item.Value + ",");
                else
                    str.Append("" + item.Key + " = '" + item.Value + "',");
            }
            str.Remove(str.Length - 1, 1);
            str.Append(" where id=" + id + "");
            return true;
        }
        public bool AddORUpdateProperty(MaterialBaseProperty baseProperty)
        {
            return baseProperty.id == 0 ? AddProperty(baseProperty) : UpdateProperty(baseProperty);
        }
        public bool DeletePropertyById(int id)
        {
            return true;
        }
        private bool AddProperty(MaterialBaseProperty baseProperty)
        {
            //在物料表中动态创建名称为en_name值的字段
            return true;
        }
        private bool UpdateProperty(MaterialBaseProperty baseProperty)
        {
            return true;
        }
        public List<Material_ComboBox_Value> GetComboBoxValueByPropertyId(int propertyId)
        {
            return GetAllComboBoxValue().FindAll(c => c.Extend_Id == propertyId);
        }
        private List<Material_ComboBox_Value> GetAllComboBoxValue()
        {
            var comboBoxValueList = new List<Material_ComboBox_Value>();
            var comboBoxValue = new Material_ComboBox_Value
            {
                Id = 1,
                Extend_Id = 1,
                Value = "测试1",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);

            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 2,
                Extend_Id = 1,
                Value = "测试2",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);

            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 3,
                Extend_Id = 1,
                Value = "测试3",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);

            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 4,
                Extend_Id = 1,
                Value = "测试4",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            #region 物料属性
            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 5,
                Extend_Id = 2,
                Value = "外协件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 6,
                Extend_Id = 2,
                Value = "自制件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 7,
                Extend_Id = 2,
                Value = "外购件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 8,
                Extend_Id = 2,
                Value = "虚拟件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            #endregion
            #region 物料种类
            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 9,
                Extend_Id = 3,
                Value = "零件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new Material_ComboBox_Value
            {
                Id = 10,
                Extend_Id = 3,
                Value = "部件",
                Is_Delete = "0"
            };
            comboBoxValueList.Add(comboBoxValue);
            comboBoxValue = new Material_ComboBox_Value
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
        public DataTable GetListToDataTable(int propertyId)
        {
            return ToDataTable(GetComboBoxValueByPropertyId(propertyId), "comboBoxValue");
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
        public bool AddORUpdateComboBoxValue(Material_ComboBox_Value comboBoxValue)
        {
            return comboBoxValue.Id == 0 ? AddComboBoxValue(comboBoxValue) : UpdateComboBoxValue(comboBoxValue);

        }
        private bool AddComboBoxValue(Material_ComboBox_Value comboBoxValue)
        {
            return false;
        }
        private bool UpdateComboBoxValue(Material_ComboBox_Value comboBoxValue)
        {
            return true;
        }
        public List<MaterialBaseProperty> GetMaterialPropertyByTypeId(int typeId)
        {
            return GetAllMaterialProperty().FindAll(p => p.material_property_type_id == typeId);
        }
    }
}
