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
    public class MeasurementUnitBuild : IMeasurementUnitBuild
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
            u1.create_user_id = 1;
            u1.id = 1;
            u1.is_default = "";
            u1.is_delete = "是";
            u1.modify_date = new DateTime();
            u1.modify_user_id = 1;
            u1.unit_group_id = 1;



            u2.name = "枪";
            u2.number = "2";
            u2.scale = "1:3";
            u1.create_date = new DateTime();
            u1.create_user_id = 2;
            u1.id = 2;
            u1.is_default = "";
            u1.is_delete = "否";
            u1.modify_date = new DateTime();
            u1.modify_user_id = 2;
            u1.unit_group_id = 2;



            U.Add(u1);
            U.Add(u2);
            return U;
        }
        public List<UnitGroup> GetAllUnitGroup()
        {
            var UG = new BindingList<UnitGroup>();
            UnitGroup ug1 = new UnitGroup();
            UnitGroup ug2 = new UnitGroup();

            ug1.name = "652";
            ug1.number = "1";
            ug1.description = "挤爆了";
            ug1.create_date = new DateTime();
            ug1.create_user_id = 1;
            ug1.Id = 1;
            ug1.is_delete = "是";
            ug1.modify_date = new DateTime();
            ug1.modify_user_id = 1;
            ug1.Parent_Id = 0;


            ug2.name = "158";
            ug2.number = "2";
            ug2.description = "挤上天";
            ug2.create_date = new DateTime();
            ug2.create_user_id = 2;
            ug2.Id = 2;
            ug2.is_delete = "否";
            ug2.modify_date = new DateTime();
            ug2.modify_user_id = 2;
            ug2.Parent_Id = 0;

            UG.Add(ug1);
            UG.Add(ug2);
            return UG.ToList();
        }
        public bool AddORUpdateUnitGroup(UnitGroup group)
        {
            return group.Id == 0 ? AddUnitGroup(group) : UpdateUnitGroup(group);
        }
        public bool AddORUpdateUnit(Unit unit)
        {
            return unit.id == 0 ? AddUnit(unit) : UpdateUnit(unit);
        }
        private bool AddUnitGroup(UnitGroup group)
        {
            return false;
        }
        private bool UpdateUnitGroup(UnitGroup group)
        {
            return true;
        }
        private bool AddUnit(Unit unit)
        {
            return false;
        }
        private bool UpdateUnit(Unit unit)
        {
            return true;
        }
        public List<Unit> GetUnitListByGroupId(int groupId)
        {
            var unitList = new List<Unit>();
            return unitList;
        }
        public List<Unit> GetAllUnit()
        {
            var unitList = new List<Unit>();
            Unit u1 = new Unit();
            Unit u2 = new Unit();

            u1.name = "刀";
            u1.number = "1";
            u1.scale = "1:1";
            u1.create_date = new DateTime();
            u1.create_user_id = 1;
            u1.id = 1;
            u1.is_default = "";
            u1.is_delete = "是";
            u1.modify_date = new DateTime();
            u1.modify_user_id = 1;
            u1.unit_group_id = 1;

            u2.name = "枪";
            u2.number = "2";
            u2.scale = "1:3";
            u2.create_date = new DateTime();
            u2.create_user_id = 2;
            u2.id = 2;
            u2.is_default = "";
            u2.is_delete = "否";
            u2.modify_date = new DateTime();
            u2.modify_user_id = 2;
            u2.unit_group_id = 2;

            unitList.Add(u1);
            unitList.Add(u2);
            return unitList;
        }
    }
}
