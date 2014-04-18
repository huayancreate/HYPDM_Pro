using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class Material
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string No { get; set; }
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 原件号
        /// </summary>
        [DataMember]
        public string Original_No { get; set; }
        [DataMember]
        public string Version { get; set; }
        /// <summary>
        /// 属性
        /// </summary>
        [DataMember]
        public string Property_Type { get; set; }
        [DataMember]
        public string Unit_Id { get; set; }
        /// <summary>
        /// 种类
        /// </summary>
        [DataMember]
        public string Species { get; set; }
        [DataMember]
        public string Unit_Group_Id { get; set; }
        [DataMember]
        public string Weight { get; set; }
        /// <summary>
        /// 材料
        /// </summary>
        [DataMember]
        public int Material_Id { get; set; }
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        public string Is_Encode { get; set; }
        /// <summary>
        /// 物料类型
        /// </summary>
        [DataMember]
        public int Material_Type_Id { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        [DataMember]
        public string Model_No { get; set; }
        /// <summary>
        /// 物料状态
        /// </summary>
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Price { get; set; }
        /// <summary>
        /// 所属分类
        /// </summary>
        [DataMember]
        public string Category { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DataMember]
        public string Remark { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [DataMember]
        public string Standard { get; set; }
        [DataMember]
        public string Product_Type { get; set; }
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
