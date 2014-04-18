using PDM_Entity.DocManage;
using PDM_Entity.PartsMange;
using PDM_Entity.ProductStruct;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PDM_Services_Implementation.Test
{
    public class BOMData
    {
        public List<BOM> GetAllBOM()
        {
            var bomList = new List<BOM>();
            var bom = new BOM
            {
                Id = 1,
                Name = "测试数据1",
                Version = "1.0",
                Status = "未归档",
                Is_Delete = "0",
                Parent_Id = 1,
                Type = "设计BOM",
                Create_Date = DateTime.Now,
                Create_User_Id = 1,
                Description = "测试数据1"
            };

            var bom1 = new BOM
            {
                Id = 2,
                Name = "测试数据2",
                Version = "1.1",
                Status = "已归档",
                Is_Delete = "0",
                Parent_Id = 2,
                Type = "工装BOM",
                Create_Date = DateTime.Now,
                Create_User_Id = 1,
                Description = "测试数据2"
            };
            bomList.Add(bom);
            bomList.Add(bom1);
            return bomList;
        }
        public List<BOMDto> GetAllBOMDto()
        {
            var bomList = new List<BOMDto>();
            var bom = new BOMDto
            {
                Id = 1,
                Name = "测试数据1",
                Version = "1.0",
                Status = "未归档",
                Parent_Id = 1,
                UserName = "Test",
                RootNo = "201403121111",
                RootVersion = "1.1",
                Type = "设计BOM",
                Description = "测试数据1"
            };

            var bom1 = new BOMDto
            {
                Id = 2,
                Name = "测试数据2",
                Version = "1.1",
                Status = "已归档",
                Parent_Id = 2,
                UserName = "Test",
                RootNo = "201403121112",
                RootVersion = "1.2",
                Type = "工装BOM",
                Description = "测试数据2"
            };
            bomList.Add(bom);
            bomList.Add(bom1);
            return bomList;
        }
        public Material GetMaterialById(int id)
        {
            return GetAllMaterial().Find(m => m.Id == id);
        }
        public List<Material> GetAllMaterial()
        {
            var materialList = new List<Material>();
            var m = new Material { Id = 1, Name = "测试零部件1", No = "201403121111", Version = "1.1" };
            materialList.Add(m);
            m = new Material { Id = 2, Name = "测试零部件2", No = "201403121112", Version = "1.2" };
            materialList.Add(m);
            m = new Material { Id = 3, Name = "测试零部件3", No = "201404011008", Version = "1.3" };
            materialList.Add(m);
            return materialList;
        }
        public List<BOM_Struct> GetAllStructByBOMId(int bom_id)
        {
            var structList = new List<BOM_Struct>();
            structList = GetAllStruct().FindAll(s => s.BOM_Id == bom_id);
            return structList;
        }
        public List<BOM_Struct> GetAllStruct()
        {
            var structList = new List<BOM_Struct>();
            var structs = new BOM_Struct
            {
                Id = 1,
                BOM_Id = 1,
                Is_Delete = "0",
                Material_Id = 1,
                Parent_Id = 0,
                Create_Date = DateTime.Now
            };
            structList.Add(structs);

            structs = new BOM_Struct
            {
                Id = 2,
                BOM_Id = 1,
                Is_Delete = "0",
                Material_Id = 2,
                Parent_Id = 1,
                Create_Date = DateTime.Now
            };
            structList.Add(structs);

            structs = new BOM_Struct
            {
                Id = 3,
                BOM_Id = 1,
                Is_Delete = "0",
                Material_Id = 3,
                Parent_Id = 2,
                Create_Date = DateTime.Now
            };
            structList.Add(structs);

            structs = new BOM_Struct
            {
                Id = 4,
                BOM_Id = 2,
                Is_Delete = "0",
                Material_Id = 1,
                Parent_Id = 0,
                Create_Date = DateTime.Now
            };
            structList.Add(structs);

            structs = new BOM_Struct
            {
                Id = 5,
                BOM_Id = 1,
                Is_Delete = "0",
                Material_Id = 2,
                Parent_Id = 1,
                Create_Date = DateTime.Now
            };
            structList.Add(structs);

            return structList;
        }
        public BOM_Struct GetStructByMaterialId(int material_id)
        {
            var structList = GetAllStructByBOMId(1);
            var structs = structList.Find(s => s.Material_Id == material_id);
            return structs;
        }
        public BOM_Struct GetStructById(int id)
        {
            var structList = GetAllStructByBOMId(1);
            return structList.Find(s => s.Id == id);
        }
        public List<document> GetAllDocument()
        {
            var docList = new List<document>();

            var doc = new document { id = 1, cn_name = "文档测试数据1", version = "1.0", number = "201403131601", status = "未归档", dense_name = "测试", valid_time = "2014-03-25", in_valid_time = "2014-03-28" };
            docList.Add(doc);

            doc = new document { id = 2, cn_name = "文档测试数据2", version = "1.1", number = "201403131602", status = "已归档", dense_name = "测试", valid_time = "2014-03-22", in_valid_time = "2014-03-31" };
            docList.Add(doc);
            return docList;
        }

        public List<DocumentDto> GetAllDocumentDto()
        {
            var docList = new List<DocumentDto>();

            var doc = new DocumentDto { Id = 1, Doc_Name = "文档测试数据1", Doc_Version = "1.0", Doc_No = "201403131601", Doc_Status = "未归档", Doc_Dense_Name = "测试", Valid_Time = "2014-03-25", In_Valid_Time = "2014-03-28", Material_Name = "测试零部件1", Doc_Category = "分类1" };
            docList.Add(doc);

            doc = new DocumentDto { Id = 2, Doc_Name = "文档测试数据2", Doc_Version = "1.1", Doc_No = "201403131602", Doc_Status = "已归档", Doc_Dense_Name = "测试", Valid_Time = "2014-03-22", In_Valid_Time = "2014-03-31", Material_Name = "测试零部件2", Doc_Category = "分类2" };
            docList.Add(doc);
            return docList;
        }
        public List<Doc_Material> GetAllDocParts()
        {
            var docPartsList = new List<Doc_Material>();
            var docParts = new Doc_Material { Id = 1, Doc_Id = 2, Material_Id = 1 };
            docPartsList.Add(docParts);

            //docParts = new Doc_Parts();
            //docParts.Id = 2;
            //docParts.Doc_Id = 1;
            //docParts.Part_Id = 2;
            //docPartsList.Add(docParts);

            docParts = new Doc_Material { Id = 3, Doc_Id = 1, Material_Id = 1 };
            docPartsList.Add(docParts);

            docParts = new Doc_Material { Id = 4, Doc_Id = 2, Material_Id = 2 };
            docPartsList.Add(docParts);

            return docPartsList;
        }
        public List<document> GetDocumentByPartId(int part_id)
        {
            var partsList = GetDocPartsByPartId(part_id);
            var docList = GetAllDocument();
            return partsList.Select(part => docList.Find(doc => doc.id == part.Doc_Id)).ToList();
        }
        public List<DocumentDto> GetDocumentDtoByPartId(int part_id)
        {
            var partsList = GetDocPartsByPartId(part_id);
            var docList = GetAllDocumentDto();
            return partsList.Select(part => docList.Find(doc => doc.Id == part.Doc_Id)).ToList();
        }
        public List<Doc_Material> GetDocPartsByPartId(int material_id)
        {
            var partsList = GetAllDocParts().FindAll(p => p.Material_Id == material_id);
            //partsList = GetAllDocParts().FindAll(parts => parts.Part_Id == part_id);
            return partsList;
        }
        public BOM GetBOMById(int? bom_id)
        {
            return GetAllBOM().Find(b => b.Id == bom_id);
        }
        public List<BOM_Struct> GetStructListByMaterialId(int material_id, int bom_id)
        {
            var structList = new List<BOM_Struct>();
            var bomStruct = GetStructByMaterialId(material_id);
            structList = GetAllStructByBOMId(bom_id).FindAll(s => s.Parent_Id == bomStruct.Id);
            return structList;
        }
        public List<BOM_Struct> GetStructListByParentId(int id, int bom_id)
        {
            var structList = new List<BOM_Struct>();
            structList = GetAllStructByBOMId(bom_id).FindAll(s => s.Parent_Id == id);
            return structList;
        }
        public document GetDocumentByDocId(int doc_id)
        {
            return GetAllDocument().Find(d => d.id == doc_id);
        }
        public List<Material> GetMaterialByParentId(int id)
        {
            var materialList = new List<Material>();
            var structBOM = GetStructById(id);
            if (structBOM != null)
            {
                var structList = GetAllStructByBOMId(1).FindAll(s => s.Parent_Id == structBOM.Id);
                structList.Add(structBOM);
                foreach (var s in structList)
                {
                    materialList.Add(GetMaterialById(Convert.ToInt32(s.Material_Id)));
                }
            }
            return materialList;
        }
        public List<Material_Type> GetAllMaterailType()
        {
            var typeList = new List<Material_Type>();
            var type = new Material_Type();
            type.Id = 1;
            type.Name = "测试类型1";
            type.Parent_Id = 0;
            type.Mark = "备注1";
            type.Is_Delete = "0";
            typeList.Add(type);

            type = new Material_Type();
            type.Id = 2;
            type.Name = "测试类型11";
            type.Parent_Id = 1;
            type.Mark = "备注11";
            type.Is_Delete = "0";
            typeList.Add(type);

            return typeList;
        }
        public List<BOM> GetBOMByIsRefer(int referMaterialId)
        {
            var structList = GetAllStruct().FindAll(s => s.Material_Id == referMaterialId && s.Is_Refer == "1");
            var bomList = new List<BOM>();
            foreach (var s in structList)
            {
                var bom = GetAllBOM().Find(b => b.Id == s.BOM_Id);
                bomList.Add(bom);
            }
            return bomList;
        }
        public List<Supplier> GetAllSupplier()
        {
            var supplierList = new List<Supplier>();
            var supplier = new Supplier();
            supplier.Id = 1;
            supplier.Name = "供应商测试数据1";
            supplier.Type = "测试";
            supplier.Phone = "111111111111111";
            supplier.WebSite = "http://www.baidu.com";
            supplier.Remark = "测试";
            supplier.Category = "重要";
            supplier.Address = "北京";
            supplier.ZipCode = "100000";
            supplierList.Add(supplier);

            supplier = new Supplier();
            supplier.Id = 2;
            supplier.Name = "供应商测试数据2";
            supplier.Type = "测试";
            supplier.Phone = "22222222222222";
            supplier.WebSite = "http://www.qq.com";
            supplier.Remark = "测试";
            supplier.Category = "重要";
            supplier.Address = "深圳";
            supplier.ZipCode = "200000";
            supplierList.Add(supplier);

            return supplierList;
        }
        public Supplier GetSupplierById(int id)
        {
            var supplierList = GetAllSupplier();
            return supplierList.Find(s => s.Id == id);
        }
        #region 注释的代码
        //private List<BOM_ComboBox_Value> GetAllComboBoxValue()
        //{
        //    var comboBoxList = new List<BOM_ComboBox_Value>();
        //    var comboBox = new BOM_ComboBox_Value();
        //    comboBox.Id = 1;
        //    comboBox.Extend_Id = 1;
        //    comboBox.Value = "测试数据1";
        //    comboBox.Is_Delete = "0";
        //    comboBox.Create_User_Id = 1;
        //    comboBox.Create_Date = DateTime.Now;
        //    comboBoxList.Add(comboBox);

        //    comboBox = new BOM_ComboBox_Value();
        //    comboBox.Id = 2;
        //    comboBox.Extend_Id = 1;
        //    comboBox.Value = "测试数据2";
        //    comboBox.Is_Delete = "0";
        //    comboBox.Create_User_Id = 1;
        //    comboBox.Create_Date = DateTime.Now;
        //    comboBoxList.Add(comboBox);

        //    comboBox = new BOM_ComboBox_Value();
        //    comboBox.Id = 3;
        //    comboBox.Extend_Id = 1;
        //    comboBox.Value = "测试数据3";
        //    comboBox.Is_Delete = "0";
        //    comboBox.Create_User_Id = 1;
        //    comboBox.Create_Date = DateTime.Now;
        //    comboBoxList.Add(comboBox);
        //    return comboBoxList;
        //}
        //public List<BOM_Attached_Property> GetAllAttachedProperty()
        //{
        //    var propertyList = new List<BOM_Attached_Property>();
        //    var property = new BOM_Attached_Property();
        //    property.Id = 1;
        //    property.CN_Name = "测试数据1";
        //    property.EN_Name = "TestData";
        //    property.InputType = "TextBox";
        //    property.Is_Delete = "0";
        //    property.Is_Query = "0";
        //    property.Width = "100";
        //    propertyList.Add(property);

        //    property = new BOM_Attached_Property();
        //    property.Id = 2;
        //    property.CN_Name = "测试数据2";
        //    property.EN_Name = "TestData";
        //    property.InputType = "TextBox";
        //    property.Is_Delete = "0";
        //    property.Is_Query = "0";
        //    property.Width = "100";
        //    propertyList.Add(property);

        //    property = new BOM_Attached_Property();
        //    property.Id = 3;
        //    property.CN_Name = "测试数据3";
        //    property.EN_Name = "TestData";
        //    property.InputType = "TextBox";
        //    property.Is_Delete = "0";
        //    property.Is_Query = "0";
        //    property.Width = "100";
        //    propertyList.Add(property);

        //    return propertyList;
        //}
        #endregion

    }
}
