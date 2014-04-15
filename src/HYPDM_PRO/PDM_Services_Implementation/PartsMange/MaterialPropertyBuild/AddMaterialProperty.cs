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
    public class AddMaterialProperty :IAddMaterialProperty
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

        public IList<MaterialType> MT() 
        {
            IList<MaterialType> Ma = new BindingList<MaterialType>();
            MaterialType ma = new MaterialType();
            MaterialType mb = new MaterialType();
            MaterialType mc = new MaterialType();

            ma.child_mark_length = "10";
            ma.code_length = "8";
            ma.code_start = "10";
            ma.create_date = new DateTime(); 
            ma.create_user_id = 1001;
            ma.id = 001;
            ma.is_delete = "是";
            ma.is_last = "是";
            ma.modify_date = new DateTime();
            ma.modify_user_id = 10001;
            ma.name = "气囊";
            ma.parent_id = 1;
            ma.remark = "保命用具";

            mb.child_mark_length = "12";
            mb.code_length = "8";
            mb.code_start = "10";
            mb.create_date = new DateTime();
            mb.create_user_id = 1002;
            mb.id = 002;
            mb.is_delete = "否";
            mb.is_last = "是";
            mb.modify_date = new DateTime();
            mb.modify_user_id = 10002;
            mb.name = "油箱";
            mb.parent_id = 2;
            mb.remark = "汽车命脉";

            mc.child_mark_length = "15";
            mc.code_length = "8";
            mc.code_start = "10";
            mc.create_date = new DateTime();
            mc.create_user_id = 1003;
            mc.id =003;
            mc.is_delete = "否";
            mc.is_last = "否";
            mc.modify_date = new DateTime();
            mc.modify_user_id = 10003;
            mc.name = "方向盘";
            mc.parent_id = 3;
            mc.remark = "汽车眼睛";

            Ma.Add(ma);
            Ma.Add(mb);
            Ma.Add(mc);
            return Ma;
        }
    }
}
