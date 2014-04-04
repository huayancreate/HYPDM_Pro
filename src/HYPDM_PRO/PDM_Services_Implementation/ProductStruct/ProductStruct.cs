using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using PDM_Entity.ProductStruct;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using PDM_Entity.DocManage;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ProductStruct : IProductStruct
    {
        public bool AddORUpdateBOM(BOM bom)
        {
            var sql = new StringBuilder();
            if (bom.Id == null)
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
        public bool AddORUpdatePorperty(BOM_Attached_Property property)
        {
            return true;
        }
        public bool AddORUpdateComboBoxValue(BOM_ComboBox_Value value)
        {
            return true;
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
        public Materialcs GetMaterialById(int id)
        {
            return new Test.BOMData().GetMaterialById(id);
        }
        public List<DocumentDto> GetDocWithMaterailByMaterialId(int id)
        {
            var docMaterialList = new Test.BOMData().GetDocPartsByPartId(id);
            var docList = new Test.BOMData().GetAllDocumentDto();
            return docMaterialList.Select(doc_m => docList.Find(doc => doc.Id == doc_m.Doc_Id)).ToList();
        }
        public BOM_Struct GetBOMStructByMaterialId(int materialId, int bomId)
        {
            var list = new Test.BOMData().GetStructListByMaterialId(materialId, bomId);
            if (list.Count > 0)
                return list[0];
            return null;
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
        public List<Materialcs> GetAllMaterialList(int id, int bomId)
        {
            var materialList = new List<Materialcs>();
            var structList = GetBOMStructListByParentId(id, bomId);
            foreach (var item in structList)
            {
                materialList.Add(GetMaterialById(item.Material_Id));
            }
            return materialList;
        }
    }
}
