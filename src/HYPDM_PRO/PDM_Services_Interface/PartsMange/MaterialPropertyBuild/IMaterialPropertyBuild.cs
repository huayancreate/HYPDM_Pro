using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using System.Collections;
using System.Data;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMaterialPropertyBuild
    {
        /// <summary>
        /// 获取所有物料属性集合[基础属性和附加属性]
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MaterialBaseProperty> GetAllMaterialProperty();
        [OperationContract]
        bool UpdatePropertyWithTable(string table, Dictionary<string, object> columns, int id);
        [OperationContract]
        bool AddORUpdateProperty(MaterialBaseProperty baseProperty);
        [OperationContract]
        bool DeletePropertyById(int id);
        [OperationContract]
        List<Material_ComboBox_Value> GetComboBoxValueByPropertyId(int propertyId);
        [OperationContract]
        DataTable GetListToDataTable(int propertyId);
        [OperationContract]
        bool AddORUpdateComboBoxValue(Material_ComboBox_Value comboBoxValue);
        [OperationContract]
        DataTable ToDataTable(IList list, string tableName);
        [OperationContract]
        List<MaterialBaseProperty> GetMaterialPropertyByTypeId(int typeId);
    }
}
