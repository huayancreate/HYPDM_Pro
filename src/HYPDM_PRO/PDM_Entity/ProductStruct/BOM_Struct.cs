using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.ProductStruct
{
    [DataContract]
    public class BOM_Struct
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int BOM_Id { get; set; }
        [DataMember]
        public int Parent_Id { get; set; }
        [DataMember]
        public int Material_Id { get; set; }
        [DataMember]
        public string Is_Delete { get; set; }
        /// <summary>
        /// 参考BOM主键
        /// </summary>
        [DataMember]
        public int ReferBOM_Id { get; set; }
        /// <summary>
        /// 是否引用零部件
        /// </summary>
        [DataMember]
        public string Is_Refer { get; set; }
        [DataMember]
        public DateTime Create_Date { get; set; }
        [DataMember]
        public int Create_User_Id { get; set; }
        [DataMember]
        public DateTime Modify_Date { get; set; }
        [DataMember]
        public int Modify_User_Id { get; set; }
        [DataMember]
        public string Material_Name { get; set; }
    }
}
