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
    public  class MaterialBankManage : IMaterialBankManage
    {

        public IList<MaterialBaseProperty> MB() 
        {
            IList<MaterialBaseProperty> B = new BindingList<MaterialBaseProperty>();
            MaterialBaseProperty Ma = new MaterialBaseProperty();
            MaterialBaseProperty Mb = new MaterialBaseProperty();

            Ma.cn_name = "李元霸";
            Ma.create_date = new DateTime();
            Ma.create_user_id = 001;
            Ma.data_length = "10";
            Ma.data_type = "";
            Ma.default_value = "";
            Ma.en_name = "";
            Ma.id = 001;
            Ma.input_type = "自动";
            Ma.is_delete = "是";
            Ma.is_extends = "否";
            Ma.is_query = "否";
            Ma.material_property_type_id = 001;
            Ma.modify_date = new DateTime();
            Ma.modify_user_id = 001;
            Ma.property_type = "外协";
            Ma.required = "是";
            Ma.width = "20px";
            Ma.number = 001;
            Ma.property = "虚拟件";
            Ma.variety = "零件";
            Ma.weight = "50kg";
            Ma.type = "YF—1056";
            Ma.belong_classify = "F-01";
            Ma.product_type = "10056";
            Ma.original_number = 000;
            Ma.version = "001";
            Ma.unit_measure = "件";
            Ma.unit_measure_group = "数量单位";
            Ma.material = "钢";
            Ma.cost_price = "30000";
            Ma.norms = "01";
            Ma.remark = "天下无双";






            Mb.cn_name = "裴元庆";
            Mb.create_date = new DateTime();
            Mb.create_user_id = 002;
            Mb.data_length = "";
            Mb.data_type = "";
            Mb.default_value = "";
            Mb.en_name = "";
            Mb.id = 002;
            Mb.input_type = "手动";
            Mb.is_delete = "是";
            Mb.is_extends = "是";
            Mb.is_query = "是";
            Mb.material_property_type_id = 002;
            Mb.modify_date = new DateTime();
            Mb.modify_user_id = 002;
            Mb.property_type = "内协";
            Mb.required = "是";
            Mb.width = "50px";
            Mb.number = 002;
            Mb.property = "虚拟件";
            Mb.variety = "零件";
            Mb.weight = "45kg";
            Mb.type = "BA—1267";
            Mb.belong_classify = "B-01";
            Mb.product_type = "10348";
            Mb.original_number = 002;
            Mb.version = "002";
            Mb.unit_measure = "个";
            Mb.unit_measure_group = "数量单位";
            Mb.material = "铜";
            Mb.cost_price = "20000";
            Mb.norms = "02";
            Mb.remark = "翻江倒海";
            //Material Ma = new Material();
            //Material Mb = new Material();
            //Material Mc = new Material();
            //Material Md = new Material();

            //Ma.number = "1001";
            //Ma.image = "无";
            //Ma.is_enable = "有效";
            //Ma.status = "设计状态";
            //Ma.versions = "外协件";
            //Ma.type = "战斗机";
            //Ma.cn_name = "李元霸";
            //Ma.property = "天下无双";
            //Ma.create_date = new DateTime();
            //Ma.create_user_id = 001;
            //Ma.id = 1001;
            //Ma.is_delete = "否";
            //Ma.is_encode = "不使用";
            ////Ma.is_property = "";
            //Ma.is_show = "是";
            //Ma.material_box_id = 001;
            ////Ma.Material_Type = "";
            //Ma.material_type_id = 001;
            //Ma.modify_date = new DateTime();
            //Ma.modify_user_id = 001;
            ////Ma.name = "";
            //Ma.product_category_id = 001;
            ////Ma.property_type = "";
            //Ma.supplied_id = 001;
            //Ma.unit_id = 001;
            ////Ma.widgh = "";

            //Mb.number = "1002";
            //Mb.image = "无";
            //Mb.is_enable = "有效";
            //Mb.status = "设计状态";
            //Mb.versions = "外协件";
            //Mb.type = "轰炸机";
            //Mb.cn_name = "宇文成都";
            //Mb.property = "纵横莫挡";
            //Ma.create_date = new DateTime();
            //Ma.create_user_id = 001;
            //Ma.id = 1001;
            //Ma.is_delete = "否";
            //Ma.is_encode = "不使用";
            //Ma.is_show = "是";
            //Ma.material_box_id = 001;
            //Ma.material_type_id = 001;
            //Ma.modify_date = new DateTime();
            //Ma.modify_user_id = 001;
            //Ma.product_category_id = 001;
            //Ma.supplied_id = 001;
            //Ma.unit_id = 001;


            //Mc.number = "1004";
            //Mc.image = "无";
            //Mc.is_enable = "有效";
            //Mc.status = "设计状态";
            //Mc.versions = "外协件";
            //Mc.type = "战斗轰炸机";
            //Mc.cn_name = "罗成";
            //Mc.property = "勇冠三军";
            //Ma.create_date = new DateTime();
            //Ma.create_user_id = 002;
            //Ma.id = 1002;
            //Ma.is_delete = "否";
            //Ma.is_encode = "不使用";
            //Ma.is_show = "是";
            //Ma.material_box_id = 002;
            //Ma.material_type_id = 002;
            //Ma.modify_date = new DateTime();
            //Ma.modify_user_id = 002;
            //Ma.product_category_id = 002;
            //Ma.supplied_id = 002;
            //Ma.unit_id = 002;

            //Md.number = "2001";
            //Md.image = "无";
            //Md.is_enable = "有效";
            //Md.status = "归档状态";
            //Md.versions = "内协件";
            //Md.type = "效率的延伸器";
            //Md.cn_name = "计算机";
            //Md.property = "缺少就没法活";
            //Ma.create_date = new DateTime();
            //Ma.create_user_id = 002;
            //Ma.id = 1002;
            //Ma.is_delete = "否";
            //Ma.is_encode = "不使用";
            //Ma.is_show = "是";
            //Ma.material_box_id = 002;
            //Ma.material_type_id = 002;
            //Ma.modify_date = new DateTime();
            //Ma.modify_user_id = 002;
            //Ma.product_category_id = 002;
            //Ma.supplied_id = 002;
            //Ma.unit_id = 002;

            B.Add(Ma);
            B.Add(Mb);
            //B.Add(Mc);
            //sB.Add(Md);
            return B;
        }

        public IList<MaterialBaseProperty> QueryMaterial() 
        {
            IList<MaterialBaseProperty> QM = new BindingList<MaterialBaseProperty>();
            MaterialBaseProperty m = new MaterialBaseProperty();
            MaterialBaseProperty m1 = new MaterialBaseProperty();
            MaterialBaseProperty m2 = new MaterialBaseProperty();
            MaterialBaseProperty m3 = new MaterialBaseProperty();

            m.cn_name = "兰博基尼";
            m.create_date = new DateTime();
            m.data_length = "蓝色血灵";
            m.default_value = "超级跑车";
            m.data_type = "全球限量50台";
            m.input_type = "10001";
            m.is_delete = "汽车";
            m.is_extends = "无";
            m.id = 10001;

            m1.cn_name = "劳斯莱斯";
            m1.create_date = new DateTime();
            m1.data_length = "银魅";
            m1.default_value = "超级跑车";
            m1.data_type = "全球限量20台";
            m1.input_type = "20001";
            m1.is_delete = "汽车";
            m1.is_extends = "无";
            m1.id = 20001;

            m2.cn_name = "法拉利";
            m2.create_date = new DateTime();
            m2.data_length = "GT 911";
            m2.default_value =  "超级跑车";
            m2.data_type = "全球限量发售";
            m2.input_type = "30001";
            m2.is_delete = "汽车";
            m2.is_extends = "无";
            m2.id = 30001;

            m3.cn_name = "奔驰";
            m3.create_date = new DateTime();
            m3.data_length = "S600";
            m3.default_value = "高档轿车";
            m3.data_type = "全球批量发售";
            m3.input_type = "40005";
            m3.is_delete = "汽车";
            m3.is_extends = "无";
            m3.id = 40005;

            QM.Add(m);
            QM.Add(m1);
            QM.Add(m2);
            QM.Add(m3);
            return QM;
        }

        public bool DeleteMaterialMessage(int id) 
        {
            return true;
        }

        public IList<MaterialBaseProperty> ModifyMaterialMessage() 
        {
            IList<MaterialBaseProperty> Mod = new BindingList<MaterialBaseProperty>();
            MaterialBaseProperty m = new MaterialBaseProperty();
            MaterialBaseProperty m1 = new MaterialBaseProperty();

            m.cn_name = "中国移动"; 
            m.create_date = new DateTime();
            m.create_user_id = 1001;
            m.data_length = "";
            m.data_type = "";
            m.default_value = "";
            m.id = 1001;
            m.input_type = "";
            m.is_delete = "是";
            m.is_extends = "是";
            m.is_query = "否";
            m.material_property_type_id = 1001;
            m.modify_date = new DateTime();
            m.modify_user_id = 1001;
            m.property_type = "";
            m.required = "";
            m.width = "19px";

            m1.cn_name = "中国电信";
            m1.create_date = new DateTime();
            m1.create_user_id = 1002;
            m1.data_length = "";
            m1.data_type = "";
            m1.default_value = "";
            m1.id = 1002;
            m1.input_type = "";
            m1.is_delete = "否";
            m1.is_extends = "是";
            m1.is_query = "否";
            m1.material_property_type_id = 1002;
            m1.modify_date = new DateTime();
            m1.modify_user_id = 1002;
            m1.property_type = "";
            m1.required = "";
            m1.width = "";


            Mod.Add(m);
            Mod.Add(m1);

            return Mod;
        }
    }
}
