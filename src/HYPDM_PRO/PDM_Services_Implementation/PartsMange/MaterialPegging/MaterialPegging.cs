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
    public class MaterialPegging : IMaterialPegging
    {
        public Material ModifyMaterialcs(string name, string type, string number) 
        {
            Material M = new Material();
            return M;
            
        }

        public IList<Material> MP() 
        {
            IList<Material> M = new BindingList<Material>();
            Material m1 = new Material();
            Material m2 = new Material();
            Material m3 = new Material();
            Material m4 = new Material();
            Material m5 = new Material();
            Material m6 = new Material();

            //m1.number = "1";
            //m1.cn_name  = "海豹";
            //m1.versions = "";
            //m1.type = "特种兵";
            //m1.image = "无";
            //m1.is_enable = "有效";
            //m1.status = "设计状态";
            //m1.create_date = new DateTime();
            //m1.create_user_id = 001;
            //m1.id = 1001;
            //m1.is_delete = "否";
            //m1.is_encode = "不使用";
            //m1.is_show = "是";
            //m1.material_box_id = 001;
            //m1.material_type_id = 001;
            //m1.modify_date = new DateTime();
            //m1.modify_user_id = 001;
            //m1.product_category_id = 001;
            //m1.supplied_id = 001;
            //m1.unit_id = 001;


            //m2.number = "2";
            //m2.cn_name = "三角洲";
            //m2.versions = "";
            //m2.type = "特种兵";
            //m2.image = "无";
            //m2.is_enable = "有效";
            //m2.status = "设计状态";
            //m2.create_date = new DateTime();
            //m2.create_user_id = 0002;
            //m2.id = 1002;
            //m2.is_delete = "否";
            //m2.is_encode = "不使用";
            //m2.is_show = "是";
            //m2.material_box_id = 002;
            //m2.material_type_id = 002;
            //m2.modify_date = new DateTime();
            //m2.modify_user_id = 002;
            //m2.product_category_id = 002;
            //m2.supplied_id = 002;
            //m2.unit_id = 002;

            //m3.number = "3";
            //m3.cn_name = "绿色贝雷帽";
            //m3.versions = "";
            //m3.type = "特种兵";
            //m3.image = "无";
            //m3.is_enable = "有效";
            //m3.status = "设计状态";
            //m3.create_date = new DateTime();
            //m3.create_user_id = 003;
            //m3.id = 1003;
            //m3.is_delete = "否";
            //m3.is_encode = "不使用";
            //m3.is_show = "是";
            //m3.material_box_id = 003;
            //m3.material_type_id = 003;
            //m3.modify_date = new DateTime();
            //m3.modify_user_id = 003;
            //m3.product_category_id = 003;
            //m3.supplied_id = 003;
            //m3.unit_id = 003;

            //m4.number = "4";
            //m4.cn_name = "枪骑兵";
            //m4.versions = "";
            //m4.type = "特种兵";
            //m4.image = "无";
            //m4.is_enable = "有效";
            //m4.status = "设计状态";
            //m4.create_date = new DateTime();
            //m4.create_user_id = 004;
            //m4.id = 1004;
            //m4.is_delete = "否";
            //m4.is_encode = "不使用";
            //m4.is_show = "是";
            //m4.material_box_id = 004;
            //m4.material_type_id = 004;
            //m4.modify_date = new DateTime();
            //m4.modify_user_id = 004;
            //m4.product_category_id = 004;
            //m4.supplied_id = 004;
            //m4.unit_id = 004;

            //m5.number = "5";
            //m5.cn_name = "海军陆战队";
            //m5.versions = "";
            //m5.type = "特种兵";
            //m5.image = "无";
            //m5.is_enable = "有效";
            //m5.status = "设计状态";
            //m5.create_date = new DateTime();
            //m5.create_user_id = 005;
            //m5.id = 1005;
            //m5.is_delete = "否";
            //m5.is_encode = "不使用";
            //m5.is_show = "是";
            //m5.material_box_id = 005;
            //m5.material_type_id = 005;
            //m5.modify_date = new DateTime();
            //m5.modify_user_id = 005;
            //m5.product_category_id = 005;
            //m5.supplied_id = 005;
            //m5.unit_id = 005;

            //m6.number = "6";
            //m6.cn_name = "中国城管大军";
            //m6.versions = "";
            //m6.type = "杀人机器";
            //m6.image = "无";
            //m6.is_enable = "有效";
            //m6.status = "设计状态";
            //m6.create_date = new DateTime();
            //m6.create_user_id = 006;
            //m6.id = 1006;
            //m6.is_delete = "否";
            //m6.is_encode = "不使用";
            //m6.is_show = "是";
            //m6.material_box_id = 006;
            //m6.material_type_id = 006;
            //m6.modify_date = new DateTime();
            //m6.modify_user_id = 006;
            //m6.product_category_id = 006;
            //m6.supplied_id = 006;
            //m6.unit_id = 006;

            M.Add(m1);
            M.Add(m2);
            M.Add(m3);
            M.Add(m4);
            M.Add(m5);
            M.Add(m6);

            return M;
        }


        public IList<Material> MB() 
        {
            IList<Material> Ma = new BindingList<Material>();
            Material ma = new Material();
            Material ma1 = new Material();
            Material ma2 = new Material();
            Material ma3 = new Material();

            //ma.name = "山姆大叔";
            //ma.type = "牛叉型";
            //ma.number = "0001";
            //ma.versions = "战斗机中的战斗机";
            //ma.create_date = new DateTime();
            //ma.create_user_id = 001;
            //ma.id = 001;
            //ma.image = "";
            //ma.is_delete = "";
            //ma.is_enable = "";
            //ma.is_encode = "";
            //ma.material_box_id = 001;
            //ma.material_type_id = 001;
            //ma.modify_date = new DateTime();
            //ma.modify_user_id = 001;
            //ma.product_category_id = 001;
            //ma.supplied_id = 001;
            //ma.status = "";
            //ma.unit_id = 001;


            //ma1.name = "北极熊";
            //ma1.type = "外强中干型";
            //ma1.number = "0002";
            //ma1.versions = "瘦死的骆驼";
            //ma.create_date = new DateTime();
            //ma.create_user_id = 002;
            //ma.id = 002;
            //ma.image = "";
            //ma.is_delete = "";
            //ma.is_enable = "";
            //ma.is_encode = "";
            //ma.material_box_id = 002;
            //ma.material_type_id = 002;
            //ma.modify_date = new DateTime();
            //ma.modify_user_id = 002;
            //ma.product_category_id = 002;
            //ma.supplied_id = 002;
            //ma.status = "";
            //ma.unit_id = 002;

            //ma2.name = "棒子";
            //ma2.type = "不要脸型";
            //ma2.number = "0003";
            //ma2.versions = "啥都是他们的";
            //ma.create_date = new DateTime();
            //ma.create_user_id = 003;
            //ma.id = 003;
            //ma.image = "";
            //ma.is_delete = "";
            //ma.is_enable = "";
            //ma.is_encode = "";
            //ma.material_box_id = 003;
            //ma.material_type_id = 003;
            //ma.modify_date = new DateTime();
            //ma.modify_user_id = 003;
            //ma.product_category_id = 003;
            //ma.supplied_id = 003;
            //ma.status = "";
            //ma.unit_id = 003;

            //ma3.name = "倭寇";
            //ma3.type = "乱咬人型";
            //ma3.number = "0004";
            //ma3.versions = "八戒的徒子徒孙";
            //ma.create_date = new DateTime();
            //ma.create_user_id = 004;
            //ma.id = 004;
            //ma.image = "";
            //ma.is_delete = "";
            //ma.is_enable = "";
            //ma.is_encode = "";
            //ma.material_box_id = 004;
            //ma.material_type_id = 004;
            //ma.modify_date = new DateTime();
            //ma.modify_user_id = 004;
            //ma.product_category_id = 004;
            //ma.supplied_id = 004;
            //ma.status = "";
            //ma.unit_id = 004;

            Ma.Add(ma);
            Ma.Add(ma1);
            Ma.Add(ma2);
            Ma.Add(ma3);
            return Ma;
        }


        public IList<Material> WB()
        {
            IList<Material> Mb = new BindingList<Material>();
            Material mb = new Material();
            Material mb1 = new Material();
            Material mb2 = new Material();

            //mb.name = "灰太狼";
            //mb.number = "1";
            //mb.type = "";
            //mb.versions = "牛逼的发明家";

            //mb1.name = "红太狼";
            //mb1.number = "2";
            //mb1.type = "";
            //mb1.versions = "杂技玩的好";

            //mb2.name = "小灰灰";
            //mb2.number = "3";
            //mb2.type = "";
            //mb2.versions = "独一无二的狼";

            Mb.Add(mb);
            Mb.Add(mb1);
            Mb.Add(mb2);
            return Mb;
        }


        public IList<Material> WP()
        {
            IList<Material> Mc = new BindingList<Material>();
            Material mc = new Material();
            Material mc1 = new Material();
            Material mc2 = new Material();

            //mc.name = "天灾军团";
            //mc.number = "001";
            //mc.type = "";
            //mc.versions = "";

            //mc1.name = "近卫军团";
            //mc1.number = "002";
            //mc1.type = "";
            //mc1.versions = "";

            //mc2.name = "燃烧军团";
            //mc2.number = "003";
            //mc2.type = "";
            //mc2.versions = "";

            Mc.Add(mc);
            Mc.Add(mc1);
            Mc.Add(mc2);
            return Mc;
        }


        public IList<Material> AW()
        {
            IList<Material> Md = new BindingList<Material>();
            Material md = new Material();
            Material md1 = new Material();
            Material md2 = new Material();

            //md.name = "CPU";
            //md.number = "1001";
            //md.type = "";
            //md.versions = "";

            //md1.name = "主板";
            //md1.number = "1002";
            //md1.type = "";
            //md1.versions = "";

            //md2.name = "显示器";
            //md2.number = "1003";
            //md2.type = "";
            //md2.versions = "";

            Md.Add(md);
            Md.Add(md1);
            Md.Add(md2);
            return Md;
        }


        public IList<Material> AP() 
        {
            IList<Material> Me = new BindingList<Material>();
            Material me = new Material();
            Material me1 = new Material();
            Material me2 = new Material();

            //me.name = "孙悟空";
            //me.number = "1101";
            //me.type = "异种";
            //me.versions = "老大";

            //me1.name = "猪八戒";
            //me1.number = "1201";
            //me1.type = "元帅";
            //me1.versions = "老二";

            //me2.name = "沙和尚";
            //me2.number = "1302";
            //me2.type = "将军";
            //me2.versions = "老三";

            Me.Add(me);
            Me.Add(me1);
            Me.Add(me2);
            return Me;
        }

        public IList<Material> ProjectBOMPegging() 
        {
            IList<Material> MF = new BindingList<Material>();
            Material mf = new Material();
            Material mf1 = new Material();
            Material mf2 = new Material();

            //mf.name = "牛魔王";
            //mf.number = "1001";
            //mf.type = "牛精";
            //mf.versions = "";
            //mf.status = "设计状态";

            //mf1.name = "白骨精";
            //mf1.number = "1002";
            //mf1.type = "妖怪";
            //mf1.versions = "";
            //mf1.status = "归档状态";

            //mf2.name = "美猴王";
            //mf2.number = "1003";
            //mf2.type = "猴精";
            //mf2.versions = "";
            //mf2.status = "设计状态";

            MF.Add(mf);
            MF.Add(mf1);
            MF.Add(mf2);
            return MF;
        }

        public IList<Material> WorkBOMPegging() 
        {
            IList<Material> MG = new BindingList<Material>();
            Material mg = new Material();
            Material mg1 = new Material();
            Material mg2 = new Material();

            //mg.name = "轴承";
            //mg.number = "10001";
            //mg.type = "1";
            //mg.versions = "";
            //mg.status = "设计";

            //mg1.name = "齿轮";
            //mg1.number = "10002";
            //mg1.type = "12";
            //mg1.versions = "";
            //mg1.status = "设计";

            //mg2.name = "轮胎";
            //mg2.number = "10003";
            //mg2.type = "123";
            //mg2.versions = "";
            //mg2.status = "归档";

            MG.Add(mg);
            MG.Add(mg1);
            MG.Add(mg2);
            return MG;
        }

        public IList<Material> AssembleWorkPegging() 
        {
            IList<Material> MH = new BindingList<Material>();
            Material mh = new Material();
            Material mh1 = new Material();
            Material mh2 = new Material();

            //mh.name = "汽车";
            //mh.number = "1200";
            //mh.type = "21";
            //mh.versions = "";
            //mh.status = "";

            //mh1.name = "飞机";
            //mh1.number = "2200";
            //mh1.type = "213";
            //mh1.versions = "";
            //mh1.status = "";

            //mh2.name = "轮船";
            //mh2.number = "3200";
            //mh2.type = "211";
            //mh2.versions = "";
            //mh2.status = "";

            MH.Add(mh);
            MH.Add(mh1);
            MH.Add(mh2);
            return MH;
        }

      
    }
}
