using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;
using System.Collections;
using PDM_Entity.ChangeManagement;
using PDM_Entity.MyTaskBox;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ChangeManagementService : IChangeManagementService
    {
        public void CreateChangeApplication(Hashtable attr) { 
            
        }
        public List<ChangeApplicatioin> GetChangeApplicatioinByCondition(Hashtable condition)
        {
            return new List<ChangeApplicatioin>()
            {
                new ChangeApplicatioin(){ID=1,Type="123",Code="012222015",Name="红色部分为",Extension="JPG",Version="00",EffectTime="2014-05-14 16:32:59",State="已归档",SecurityLevel="一般",Creator="魏岚",Remark="..."},
                new ChangeApplicatioin(){ID=2,Type="123",Code="012222015",Name="红色部分为",Extension="JPG",Version="00",EffectTime="2014-05-14 16:32:59",State="已归档",SecurityLevel="一般",Creator="魏岚",Remark="..."},
                new ChangeApplicatioin(){ID=3,Type="123",Code="012222015",Name="红色部分为",Extension="JPG",Version="00",EffectTime="2014-05-14 16:32:59",State="已归档",SecurityLevel="一般",Creator="魏岚",Remark="..."},
                new ChangeApplicatioin(){ID=4,Type="123",Code="012222015",Name="红色部分为",Extension="JPG",Version="00",EffectTime="2014-05-14 16:32:59",State="已归档",SecurityLevel="一般",Creator="魏岚",Remark="..."},
                new ChangeApplicatioin(){ID=5,Type="123",Code="012222015",Name="红色部分为",Extension="JPG",Version="00",EffectTime="2014-05-14 16:32:59",State="已归档",SecurityLevel="一般",Creator="魏岚",Remark="..."},
                new ChangeApplicatioin(){ID=6,Type="123",Code="012222015",Name="红色部分为",Extension="JPG",Version="00",EffectTime="2014-05-14 16:32:59",State="已归档",SecurityLevel="一般",Creator="魏岚",Remark="..."},
            };
        }
        public List<Document> GetChangeDocumentsByChangeApplicationID(int id)
        {
            return new List<Document>() { 
                new Document(){ID=1,Type="123",Code="012222015",Name="红色部分为",Extension="JPG",Version="00",EffectTime="2014-05-14 16:32:59",State="已归档",SecurityLevel="一般",Creator="魏岚"},
            };
        }
        public List<ChangeStructure> GetChangeStructureByChangeApplicationID(int id)
        {
            return new List<ChangeStructure>()
            {
                new ChangeStructure(){ID=1,PartCode="YB0000003",PartVersion="01",ParentCode="YB0000000",ParentVersion="00",OldPartCode="YB0000003",OldPartVersion="00",Name="YB0000003"},
            };
        }
        public List<Group> GetGroupsByUserID(int userid)
        {
            return new List<Group>()
            {
                new Group(){ID=1,Name="测试组" },
                new Group(){ID=2,Name="设计组" },
                new Group(){ID=3,Name="焊接组" },
            };
        }
        public List<User> GetUsersByGroupID(int groupid)
        {
            return new List<User>(){
                new User(){ID=1,Name="cj"},
                new User(){ID=2,Name="ggg"},
                new User(){ID=3,Name="sfg"},
                new User(){ID=4,Name="ser"},
            };
        }
        public void AddGroupWithUserID(Hashtable hashtable)
        {

        }
        public void ModifyGroupByID(Hashtable hashtable)
        {

        }
        public void DeleteGroupByID(int id)
        {

        }
        public List<Document> getAllDocuments() { 
            return new List<Document>(){
                new Document(){ID=1,IsCheck=true,Code="CPC400",Name="Cha02m",Extension="XLS"},
                new Document(){ID=1,IsCheck=false,Code="CPC401",Name="12245",Extension="JPG"},
            };
        }
    }
}
