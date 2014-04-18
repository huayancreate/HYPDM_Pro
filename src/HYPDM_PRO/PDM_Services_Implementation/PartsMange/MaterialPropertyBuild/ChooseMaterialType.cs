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
        public IList<Material_Type> MaterType()
        {
            IList<Material_Type> Mat = new BindingList<Material_Type>();
            Material_Type M = new Material_Type();

            M.Child_Mark_Length = "20";
            M.Code_Length = "15";
            M.Code_Start = "10";
            M.Create_Date = new DateTime();
            M.Create_User_Id = 1;
            M.Id = 1;
            M.Is_Delete = "是";
            M.Is_Last = "是";
            M.Modify_Date = new DateTime();
            M.Modify_User_Id = 1;
            M.Name = "物料编号";
            M.Parent_Id = 1;
            M.Mark = "用于物料的";
            Mat.Add(M);

            M = new Material_Type();
            M.Child_Mark_Length = "10";
            M.Code_Length = "25";
            M.Code_Start = "100";
            M.Create_Date = new DateTime();
            M.Create_User_Id = 1;
            M.Id = 1;
            M.Is_Delete = "否";
            M.Is_Last = "是";
            M.Modify_Date = new DateTime();
            M.Modify_User_Id = 1;
            M.Name = "文档编号";
            M.Parent_Id = 1;
            M.Mark = "";
            Mat.Add(M);
            return Mat;
        }
    }
}
