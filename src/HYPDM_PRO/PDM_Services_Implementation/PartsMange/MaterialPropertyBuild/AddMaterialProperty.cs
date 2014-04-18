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
    public class AddMaterialProperty : IAddMaterialProperty
    {
        //public IList<MaterialBaseProperty> AddMaterialcs() 
        //{
        //    IList<MaterialBaseProperty> MP = new BindingList<MaterialBaseProperty>();
        //    MaterialBaseProperty m = new MaterialBaseProperty();
        //    MaterialBaseProperty m1 = new MaterialBaseProperty();

        //    m.cn_name = "零件";
        //    m.data_type = "";
        //    m.data_length = "10";
        //    m.input_type = "";
        //    m.is_extends = "是";
        //    m.create_date = new DateTime();
        //    m.create_user_id = 001;
        //    m.default_value = "1";
        //    m.en_name = "";
        //    m.id = 001;
        //    m.is_delete = "否";
        //    m.is_query = "是";
        //    m.material_property_type_id = 001;
        //    m.modify_date = new DateTime();
        //    m.modify_user_id = 001;
        //    m.property_type = "";
        //    m.required = "是";
        //    m.width = "50px";


        //    m1.cn_name = "物料";
        //    m1.data_type = "";
        //    m1.data_length = "20";
        //    m1.input_type = "";
        //    m1.is_extends = "否";
        //    m1.create_date = new DateTime();
        //    m1.create_user_id = 002;
        //    m1.default_value = "2";
        //    m1.en_name = "";
        //    m1.id = 002;
        //    m1.is_delete = "否";
        //    m1.is_query = "否";
        //    m1.material_property_type_id = 002;
        //    m1.modify_date = new DateTime();
        //    m1.modify_user_id = 002;
        //    m1.property_type = "";
        //    m1.required = "否";
        //    m1.width = "100px";

        //    MP.Add(m1);
        //    MP.Add(m);

        //    return MP;
        //}

        public IList<MaterialBaseProperty> Mat()
        {
            IList<MaterialBaseProperty> M = new BindingList<MaterialBaseProperty>();
            MaterialBaseProperty mab = new MaterialBaseProperty();
            MaterialBaseProperty mab1 = new MaterialBaseProperty();

            mab.is_extends = "是";
            mab.cn_name = "小灰灰";
            mab.create_date = new DateTime();
            mab.create_user_id = 1001;
            mab.data_length = "11";
            mab.data_type = "";
            mab.default_value = "01";
            mab.en_name = "";
            mab.id = 1001;
            mab.input_type = "";
            mab.is_delete = "是";
            mab.is_query = "否";
            mab.material_property_type_id = 1001;
            mab.modify_date = new DateTime();
            mab.modify_user_id = 1001;
            mab.property_type = "";
            mab.required = "是";
            mab.width = "100px";


            mab1.is_extends = "否";
            mab1.cn_name = "大灰灰";
            mab1.create_date = new DateTime();
            mab1.create_user_id = 1;
            mab1.data_length = "";
            mab1.data_type = "";
            mab1.default_value = "";
            mab1.en_name = "";
            mab1.id = 1;
            mab1.input_type = "";
            mab1.is_delete = "";
            mab1.is_query = "";
            mab1.material_property_type_id = 1;
            mab1.modify_date = new DateTime();
            mab1.modify_user_id = 1;
            mab1.property_type = "";
            mab1.required = "";
            mab1.width = "";

            M.Add(mab);
            M.Add(mab1);

            return M;
        }

        public bool AddMaterial(int id)
        {
            return false;
        }

        public bool DeleteMaterialType(int id)
        {
            return true;
        }

        public IList<Material_Type> MT()
        {
            IList<Material_Type> Ma = new BindingList<Material_Type>();
            var materialType = new Material_Type();

            materialType.Child_Mark_Length = "10";
            materialType.Code_Length = "8";
            materialType.Code_Start = "10";
            materialType.Create_Date = new DateTime();
            materialType.Create_User_Id = 1001;
            materialType.Id = 001;
            materialType.Is_Delete = "是";
            materialType.Is_Last = "是";
            materialType.Modify_Date = new DateTime();
            materialType.Modify_User_Id = 10001;
            materialType.Name = "气囊";
            materialType.Parent_Id = 1;
            materialType.Mark = "保命用具";
            Ma.Add(materialType);

            materialType.Child_Mark_Length = "12";
            materialType.Code_Length = "8";
            materialType.Code_Start = "10";
            materialType.Create_Date = new DateTime();
            materialType.Create_User_Id = 1002;
            materialType.Id = 002;
            materialType.Is_Delete = "否";
            materialType.Is_Last = "是";
            materialType.Modify_Date = new DateTime();
            materialType.Modify_User_Id = 10002;
            materialType.Name = "油箱";
            materialType.Parent_Id = 2;
            materialType.Mark = "汽车命脉";
            Ma.Add(materialType);

            materialType.Child_Mark_Length = "15";
            materialType.Code_Length = "8";
            materialType.Code_Start = "10";
            materialType.Create_Date = new DateTime();
            materialType.Create_User_Id = 1003;
            materialType.Id = 003;
            materialType.Is_Delete = "否";
            materialType.Is_Last = "否";
            materialType.Modify_Date = new DateTime();
            materialType.Modify_User_Id = 10003;
            materialType.Name = "方向盘";
            materialType.Parent_Id = 3;
            materialType.Mark = "汽车眼睛";
            Ma.Add(materialType);
            return Ma;
        }
    }
}
