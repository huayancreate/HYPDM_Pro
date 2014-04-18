using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.PartsMange
{
    /// <summary>
    /// 属性下拉框值表
    /// </summary>
    [DataContract]
    public class Material_ComboBox_Value
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// 属性扩展表主键
        /// </summary>
        [DataMember]
        public int Extend_Id { get; set; }
        /// <summary>
        /// 下拉框值
        /// </summary>
        [DataMember]
        public string Value { get; set; }
        /// <summary>
        /// 是否删除 [0:否 1:是]
        /// </summary>
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
