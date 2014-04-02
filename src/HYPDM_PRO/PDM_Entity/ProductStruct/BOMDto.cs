using PDM_Entity.PartsMange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.ProductStruct
{
    /// <summary>
    /// 用于BOM显示
    /// </summary>
    [DataContract]
    public class BOMDto
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
        /// <summary>
        /// 父类编号
        /// </summary>
        [DataMember]
        public int Parent_Id { get; set; }
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
        public string RootNo { get; set; }
        [DataMember]
        public string RootVersion { get; set; }
        [DataMember]
        public string UserName { get; set; }
    }
}
