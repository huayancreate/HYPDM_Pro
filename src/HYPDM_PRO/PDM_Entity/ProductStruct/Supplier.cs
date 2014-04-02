using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.ProductStruct
{
    [DataContract]
    public class Supplier
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string WebSite { get; set; }
        [DataMember]
        public string Remark { get; set; }
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
