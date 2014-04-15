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
    public class ChooseMaterialType : IChooseMaterialType
    {
        public IList<MaterialType> MaterType()
    {
            IList<MaterialType> Mat = new BindingList<MaterialType>();
            MaterialType M = new MaterialType();
            MaterialType M1 = new MaterialType();

            M.child_mark_length = "20";
            M.code_length = "15";
            M.code_start = "10";
            M.create_date = new DateTime();
            M.create_user_id = 1;
            M.id = 1;
            M.is_delete = "是";
            M.is_last = "是";
            M.modify_date = new DateTime();
            M.modify_user_id = 1;
            M.name = "物料编号";
            M.parent_id = 1;
            M.remark = "用于物料的";

            M1.child_mark_length = "10";
            M1.code_length = "25";
            M1.code_start = "100";
            M1.create_date = new DateTime();
            M1.create_user_id = 1;
            M1.id = 1;
            M1.is_delete = "否";
            M1.is_last = "是";
            M1.modify_date = new DateTime();
            M1.modify_user_id = 1;
            M1.name = "文档编号";
            M1.parent_id = 1;
            M1.remark = "";

            Mat.Add(M);
            Mat.Add(M1);

            return Mat;             
    }
    }
}
