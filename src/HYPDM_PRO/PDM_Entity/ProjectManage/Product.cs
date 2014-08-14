using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 产品类
    /// </summary>
    [DataContract]
    public class Product
    {
        /// <summary>
        /// 项目编号，主键
        /// </summary>
        [DataMember(Order = 1)]
        public int Id { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        [DataMember(Order = 2)]
        public int ProjectId { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        [DataMember(Order = 3)]
        public string Name { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [DataMember(Order = 4)]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [DataMember(Order = 5)]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        [DataMember(Order = 6)]
        public int UserId { get; set; }
        /// <summary>
        /// 流程编号
        /// </summary>
        [DataMember(Order = 7)]
        public int ProcessId { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        [DataMember(Order = 8)]
        public int CreateUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DataMember(Order = 9)]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改人编号
        /// </summary>
        [DataMember(Order = 10)]
        public int ModifyUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [DataMember(Order = 11)]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 删除标记(0否、1是)
        /// </summary>
        [DataMember(Order = 12)]
        public string IsDelete { get; set; }
        /// <summary>
        /// 产品版本
        /// </summary>
        [DataMember(Order = 13)]
        public string Versions { get; set; }
        /// <summary>
        /// 产品类型
        /// </summary>
        [DataMember(Order = 14)]
        public string Type { get; set; }
        /// <summary>
        /// 产品描述
        /// </summary>
        [DataMember(Order = 15)]
        public string Description { get; set; }
    }
}
