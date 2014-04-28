using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.ProductStruct
{
    [DataContract]
    public class SupplierQuota
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Amount { get; set; }
        [DataMember]
        public int Supplier_Id { get; set; }
        [DataMember]
        public string Is_Delete { get; set; }
        [DataMember]
        public int Create_User_Id { get; set; }
        [DataMember]
        public DateTime Create_Date { get; set; }
        [DataMember]
        public int Modify_User_Id { get; set; }
        [DataMember]
        public DateTime Modify_Date { get; set; }
    }
}
