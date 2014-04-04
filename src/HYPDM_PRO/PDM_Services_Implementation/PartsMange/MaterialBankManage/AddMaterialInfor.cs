using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using PDM_Entity.PartsMange;
using System.ComponentModel;


namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.PerCall, 
        Namespace = "PDM_Services_Implementation")]
    public class AddMaterialInfor : IAddMaterialInfor
    {
        public IList<MaterialBaseProperty> MaterialMessage(int id)
        {
            IList<MaterialBaseProperty> mater = new BindingList<MaterialBaseProperty>();
            MaterialBaseProperty m = new MaterialBaseProperty();

            m.cn_name = "";
            m.create_date = new DateTime();
            m.create_user_id = 1;
            m.data_length = "";
            m.data_type = "";
            m.default_value = "";
            m.en_name = "";
            m.id = 1;
            m.input_type = "";
            m.is_delete = "";
            m.is_extends = "";
            m.is_query = "";
            m.material_property_type_id = 1;
            m.modify_date = new DateTime();
            m.modify_user_id = 1;
            m.property_type = "";
            m.required = "";
            m.width = "";

            mater.Add(m);

            return mater;
        }

        public bool SaveMaterial(int id) 
        {
            return false;
        }
    }
}
