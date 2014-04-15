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
    public class MeasurementUnitBuild :IMeasurementUnitBuild
    {
        public IList<Unit> list1()
        {
            IList<Unit> U = new BindingList<Unit>();
            Unit u1 = new Unit();
            Unit u2 = new Unit();

            u1.name = "刀";
            u1.number = "1";
            u1.scale = "1:1";
            u1.create_date = new DateTime();
            u1.create_user_id = 001;
            u1.id = 001;
            u1.is_default = "";
            u1.is_delete = "是";
            u1.modify_date = new DateTime();
            u1.modify_user_id = 001;
            u1.unit_group_id = 001;
                 
           

            u2.name = "枪";
            u2.number = "2";
            u2.scale = "1:3";
            u1.create_date = new DateTime();
            u1.create_user_id = 002;
            u1.id = 002;
            u1.is_default = "";
            u1.is_delete = "否";
            u1.modify_date = new DateTime();
            u1.modify_user_id = 002;
            u1.unit_group_id = 002;



            U.Add(u1);
            U.Add(u2);
            return U;
        }

        public IList<UnitGroup> list2() 
        {
            IList<UnitGroup> UG = new BindingList<UnitGroup>();
            UnitGroup ug1 = new UnitGroup();
            UnitGroup ug2 = new UnitGroup();

            ug1.name = "652";
            ug1.number = "1";
            ug1.description = "挤爆了";
            ug1.create_date = new DateTime();
            ug1.create_user_id = 001;
            ug1.id = 001;
            ug1.is_delete = "是";
            ug1.modify_date = new DateTime();
            ug1.modify_user_id = 001;
            


            ug2.name = "158";
            ug2.number = "2";
            ug2.description = "挤上天";
            ug1.create_date = new DateTime();
            ug1.create_user_id = 002;
            ug1.id = 002;
            ug1.is_delete = "否";
            ug1.modify_date = new DateTime();
            ug1.modify_user_id = 002;

            UG.Add(ug1);
            UG.Add(ug2);
            return UG;
        }

        public bool AddUnitGroup(int id) 
        {

            return true;
        }
    }
}
