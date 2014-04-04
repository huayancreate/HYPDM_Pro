using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.DocManage
{
    [DataContract]
    public class DocumentDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Doc_Name { get; set; }
        [DataMember]
        public string Doc_Category { get; set; }
        [DataMember]
        public string Doc_No { get; set; }
        [DataMember]
        public string Doc_Status { get; set; }
        [DataMember]
        public string Doc_Version { get; set; }
        [DataMember]
        public string Doc_Dense_Name { get; set; }
        [DataMember]
        public string Material_Name { get; set; }
        [DataMember]
        public string Valid_Time { get; set; }
        [DataMember]
        public string In_Valid_Time { get; set; }
    }
}
