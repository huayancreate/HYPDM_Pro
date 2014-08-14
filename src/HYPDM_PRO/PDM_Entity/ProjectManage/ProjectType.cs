using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 项目类型
    /// </summary>
    [DataContract]
    public class ProjectType
    {
        /// <summary>
        /// 产品类型编号
        /// </summary>
        [DataMember(Order = 1)]
        public int Id { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        [DataMember(Order = 2)]
        public int CreateUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DataMember(Order = 3)]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改人编号
        /// </summary>
        [DataMember(Order = 4)]
        public int ModifyUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [DataMember(Order = 5)]
        public DateTime ModifyTime { get; set; }
        /// <summary>
        /// 删除标志（0：否，1：是）
        /// </summary>
        [DataMember(Order = 6)]
        public string IsDelete { get; set; }
        /// <summary>
        /// 项目类型名称
        /// </summary>
        [DataMember(Order = 7)]
        public string Name { get; set; }
        /// <summary>
        /// 项目类型父编号
        /// </summary>
        [DataMember(Order = 8)]
        public int ParentId { get; set; }
    }
}
