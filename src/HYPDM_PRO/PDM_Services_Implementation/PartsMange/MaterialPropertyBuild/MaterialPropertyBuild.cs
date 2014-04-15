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

    public class MaterialPropertyBuild : IMaterialPropertyBuild
    {
        public Material GetMaterialcsBuild(string name, string type)
        {
            Material Mate = new Material();
            return Mate;
        }

        public int AddBuild(int x, int y)
        {
            x = x + y;
            return x;
        }

        public IList<MaterialBaseProperty> Mate()
        {
            IList<MaterialBaseProperty> list = new BindingList<MaterialBaseProperty>();

            MaterialBaseProperty M = new MaterialBaseProperty();
            MaterialBaseProperty Ma = new MaterialBaseProperty();
            M.cn_name = "轴承";
            M.data_type = "50px";
            M.data_length = "是";
            M.default_value = "是";
            M.is_extends = "是";
            M.property_type = "10";
            M.material_property_type_id = 1;
            M.width = "54px";

            Ma.cn_name = "轮胎";
            Ma.data_type = "45px";
            Ma.data_length = "是";
            Ma.default_value = "是";
            Ma.is_extends = "否";
            Ma.property_type = "20";
            M.material_property_type_id = 2;
            M.width = "100px";

            list.Add(M);
            list.Add(Ma);

            return list;
        }

        public bool  DeleteMaterialBuild(int id)
        {
            return true;
        }

    }   
}
