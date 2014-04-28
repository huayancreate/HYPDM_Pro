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
    public class MaterialBankManage : IMaterialBankManage
    {
        public List<Material> GetAllMaterial()
        {
            var materialList = new List<Material>();
            var material = new Material();
            material.Id = 1;
            material.No = "20140418";
            material.Name = "测试物料1";
            material.Original_No = "2014041801";
            material.Price = "1214.34";
            material.Product_Type = "1";
            material.Property_Type = "2";
            material.Species = "1";
            material.Standard = "ISO9001";
            material.Status = "设计状态";
            material.Unit_Group_Id = "1";
            material.Unit_Id = "1";
            material.Version = "1.1";
            material.Weight = "104";
            material.Is_Encode = "false";
            material.Is_Delete = "0";
            material.Image = "";
            material.Category = "1";
            material.Create_Date = DateTime.Now;
            material.Create_User_Id = 1;
            material.Material_Id = 0;
            material.Material_Type_Id = 1;
            material.Model_No = "100-300-500";
            material.Remark = "测试数据1";
            materialList.Add(material);

            material = new Material();
            material.Id = 2;
            material.No = "20140422";
            material.Name = "测试物料2";
            material.Original_No = "2014042202";
            material.Price = "1214.34";
            material.Product_Type = "2";
            material.Property_Type = "2";
            material.Species = "4";
            material.Standard = "ISO9001";
            material.Status = "设计状态";
            material.Unit_Group_Id = "1";
            material.Unit_Id = "1";
            material.Version = "1.1";
            material.Weight = "104";
            material.Is_Encode = "false";
            material.Is_Delete = "0";
            material.Image = "";
            material.Category = "1";
            material.Create_Date = DateTime.Now;
            material.Create_User_Id = 1;
            material.Material_Id = 0;
            material.Material_Type_Id = 1;
            material.Model_No = "100-311-500";
            material.Remark = "测试数据2";
            materialList.Add(material);

            material = new Material();
            material.Id = 3;
            material.No = "201404221022";
            material.Name = "测试物料3";
            material.Original_No = "2014042202";
            material.Price = "1214.34";
            material.Product_Type = "3";
            material.Property_Type = "1";
            material.Species = "2";
            material.Standard = "ISO9001";
            material.Status = "设计状态";
            material.Unit_Group_Id = "1";
            material.Unit_Id = "1";
            material.Version = "1.1";
            material.Weight = "104";
            material.Is_Encode = "false";
            material.Is_Delete = "0";
            material.Image = "";
            material.Category = "1";
            material.Create_Date = DateTime.Now;
            material.Create_User_Id = 1;
            material.Material_Id = 0;
            material.Material_Type_Id = 1;
            material.Model_No = "100-312-500";
            material.Remark = "测试数据3";
            materialList.Add(material);

            material = new Material();
            material.Id = 4;
            material.No = "201404221023";
            material.Name = "测试物料4";
            material.Original_No = "2014042202";
            material.Price = "1214.34";
            material.Product_Type = "2";
            material.Property_Type = "4";
            material.Species = "3";
            material.Standard = "ISO9001";
            material.Status = "设计状态";
            material.Unit_Group_Id = "1";
            material.Unit_Id = "1";
            material.Version = "1.1";
            material.Weight = "104";
            material.Is_Encode = "false";
            material.Is_Delete = "0";
            material.Image = "";
            material.Category = "1";
            material.Create_Date = DateTime.Now;
            material.Create_User_Id = 1;
            material.Material_Id = 0;
            material.Material_Type_Id = 1;
            material.Model_No = "100-312-500";
            material.Remark = "测试数据4";
            materialList.Add(material);
            return materialList;
        }
        public bool AddORUpdateType(Material_Type type)
        {
            return type.Id != 0 ? UpdateMaterialType(type) : AddMaterialType(type);
        }
        private bool AddMaterialType(Material_Type type)
        {
            return true;
        }
        private bool UpdateMaterialType(Material_Type type)
        {
            return false;
        }
        public List<Material_Type> GetAllMaterialType()
        {
            var list = new List<Material_Type>();
            var materialType = new Material_Type();
            materialType.Child_Mark_Length = "20";
            materialType.Code_Length = "15";
            materialType.Code_Start = "10";
            materialType.Create_Date = new DateTime();
            materialType.Create_User_Id = 1;
            materialType.Id = 1;
            materialType.Is_Delete = "1";//0：否 1：是
            materialType.Is_Last = "1";
            materialType.Modify_Date = new DateTime();
            materialType.Modify_User_Id = 1;
            materialType.Name = "物料编号";
            materialType.Parent_Id = 0;
            materialType.Mark = "用于物料的";
            list.Add(materialType);

            materialType = new Material_Type();
            materialType.Child_Mark_Length = "10";
            materialType.Code_Length = "25";
            materialType.Code_Start = "100";
            materialType.Create_Date = new DateTime();
            materialType.Create_User_Id = 1;
            materialType.Id = 2;
            materialType.Is_Delete = "0";
            materialType.Is_Last = "0";
            materialType.Modify_Date = new DateTime();
            materialType.Modify_User_Id = 1;
            materialType.Name = "文档编号";
            materialType.Parent_Id = 0;
            materialType.Mark = "";
            list.Add(materialType);

            materialType = new Material_Type();
            materialType.Child_Mark_Length = "10";
            materialType.Code_Length = "25";
            materialType.Code_Start = "100";
            materialType.Create_Date = new DateTime();
            materialType.Create_User_Id = 1;
            materialType.Id = 3;
            materialType.Is_Delete = "0";
            materialType.Is_Last = "0";
            materialType.Modify_Date = new DateTime();
            materialType.Modify_User_Id = 1;
            materialType.Name = "文档编号1";
            materialType.Parent_Id = 2;
            materialType.Mark = "";
            list.Add(materialType);

            materialType = new Material_Type();
            materialType.Child_Mark_Length = "10";
            materialType.Code_Length = "25";
            materialType.Code_Start = "100";
            materialType.Create_Date = new DateTime();
            materialType.Create_User_Id = 1;
            materialType.Id = 4;
            materialType.Is_Delete = "0";
            materialType.Is_Last = "0";
            materialType.Modify_Date = new DateTime();
            materialType.Modify_User_Id = 1;
            materialType.Name = "文档编号2";
            materialType.Parent_Id = 2;
            materialType.Mark = "";
            list.Add(materialType);
            return list;
        }
        public List<Material> GetMaterialByTypeId(int typeId)
        {
            return GetAllMaterial().FindAll(m => m.Material_Type_Id == typeId);
        }
        public bool AddORUpdateMaterial(Material material)
        {
            return material.Id == 0 ? AddMaterial(material) : UpdateMaterial(material);
        }
        private bool AddMaterial(Material material)
        {
            return true;
        }
        private bool UpdateMaterial(Material material)
        {
            return true;
        }
        public bool DeleteMaterialType(int id)
        {
            return false;
        }
        public bool DeleteMaterial(int id)
        {
            return false;
        }
        public DataTable GetMaterialById(int id)
        {
            var dt = new DataTable("Material");
            dt.Columns.Add("luntai", typeof(string));
            dt.Columns.Add("qiche", typeof(string));
            var row = dt.NewRow();
            row["luntai"] = "测试吗";
            row["qiche"] = "测试数据1";
            dt.Rows.Add(row);
            return dt;
        }
    }
}
