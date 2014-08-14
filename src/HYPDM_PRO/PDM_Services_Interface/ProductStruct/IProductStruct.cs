using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Entity.ProductStruct;
using System.ServiceModel;
using PDM_Services_Interface;
using PDM_Entity.PartsMange;
using PDM_Entity.DocManage;
using System.Data;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IProductStruct
    {
        #region BOM相关接口
        /// <summary>
        /// 添加或者更新BOM
        /// </summary>
        /// <param name="bom"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddORUpdateBOM(BOM bom);

        /// <summary>
        /// 获取BOM集合
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<BOM> GetAllBOMList();

        /// <summary>
        /// 根据条件获取BOM集合
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        [OperationContract]
        List<BOM> GetBOMListBySql(string sql);

        /// <summary>
        /// 删除BOM
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool DeleteBOM(int id);

        [OperationContract]
        BOM GetBOMById(int bomId);

        [OperationContract]
        List<BOMDto> GetAllBOMDtoList();
        #endregion
        #region BOM结构相关接口
        /// <summary>
        /// 根据BOMId获取BOM结构集合
        /// </summary>
        /// <param name="bomId"></param>
        /// <returns></returns>
        [OperationContract]
        List<BOM_Struct> GetBOMStructListByBOMId(int bomId);

        /// <summary>
        /// 根据物料Id和BOMId获取BOM结构集合
        /// </summary>
        /// <param name="materialId"></param>
        /// <param name="bomId"></param>
        /// <returns></returns>
        [OperationContract]
        List<BOM_Struct> GetBOMStructListByMaterialId(int materialId, int bomId);

        [OperationContract]
        List<BOM_Struct> GetBOMStructListByStructId(int structId, int bomId);

        /// <summary>
        /// 根据结构Id和BOMId获取BOM结构集合
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bomId"></param>
        /// <returns></returns>
        [OperationContract]
        List<BOM_Struct> GetBOMStructListByParentId(int id, int bomId);

        /// <summary>
        /// 添加VOM结构
        /// </summary>
        /// <param name="structList"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddBOMStructWithList(List<BOM_Struct> structList);

        /// <summary>
        /// 添加BOM结构
        /// </summary>
        /// <param name="bomStruct"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddBOMStruct(BOM_Struct bomStruct);

        /// <summary>
        /// 根据物料Id和BOMId获取BOM结构对象
        /// </summary>
        /// <param name="material_id"></param>
        /// <param name="bom_id"></param>
        /// <returns></returns>
        [OperationContract]
        BOM_Struct GetBOMStructByMaterialId(int materialId, int bomId);
        #endregion
        #region 供应商相关接口
        /// <summary>
        /// 添加或更新供应商
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddORUpdateSupplier(Supplier supplier);
        /// <summary>
        /// 获取供应商集合
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Supplier> GetAllSupplierList();
        #endregion
        #region 物料相关接口
        /// <summary>
        /// 根据物料Id获取物料信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        Material GetMaterialById(int id);

        [OperationContract]
        List<Material> GetAllMaterialList(int id, int bomId);

        /// <summary>
        /// 根据物料Id获取与物料相关的文档集合
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<DocumentDto> GetDocWithMaterailByMaterialId(int id);
        #endregion
        #region 属性相关接口
        [OperationContract]
        List<BOMProperty> GetAllBOMProperty();

        /// <summary>
        /// 添加或更新附加属性
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddORUpdatePorperty(BOMProperty property);

        /// <summary>
        /// 添加或更新下拉列表框值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddORUpdateComboBoxValue(BOM_ComboBox_Value value);

        /// <summary>
        /// 根据属性Id获取下拉列表框值
        /// </summary>
        /// <param name="propertyId"></param>
        /// <returns></returns>
        [OperationContract]
        List<BOM_ComboBox_Value> GetListByPropertyId(int propertyId);

        /// <summary>
        /// 删除下拉列表框值
        /// </summary>
        /// <param name="propertyId"></param>
        /// <returns></returns>
        [OperationContract]
        bool DeleteComboBoxValue(int propertyId);

        /// <summary>
        /// 删除属性
        /// </summary>
        /// <param name="propertyId"></param>
        /// <returns></returns>
        [OperationContract]
        bool DeleteProperty(int propertyId);

        [OperationContract]
        DataTable GetListToDataTable(int propertyId);
        #endregion

        [OperationContract]
        void GetChildBOMStruct(int id, ref List<BOM_Struct> structList);
    }
}
