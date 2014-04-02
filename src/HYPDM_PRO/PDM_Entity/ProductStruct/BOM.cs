using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.ProductStruct
{
    [DataContract]
    public class BOM
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// BOM名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        public string Number { get; set; }
        /// <summary>
        /// 父类编号
        /// </summary>
        [DataMember]
        public int Parent_Id { get; set; }
        [DataMember]
        public int Process_Id { get; set; }
        /// <summary>
        /// 所属任务
        /// </summary>
        [DataMember]
        public string Belong_Task { get; set; }
        /// <summary>
        /// BOM类型 [0:设计BOM，1:工装BOM]
        /// </summary>
        [DataMember]
        public string Type { get; set; }
        /// <summary>
        /// BOM状态 [0:未归档，1:已归档]
        /// </summary>
        [DataMember]
        public string Status { get; set; }
        /// <summary>
        /// 是否删除 [0:否，1:是]
        /// </summary>
        [DataMember]
        public string Is_Delete { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        [DataMember]
        public string Version { get; set; }
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
