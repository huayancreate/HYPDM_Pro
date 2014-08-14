using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 项目属性类，包含项目所有属性一集外键
    /// </summary>
    [DataContract]
    public class Project
    {
        /// <summary>
        /// 项目编号，主键
        /// </summary>
        [DataMember(Order = 1)]
        public int Id { get; set; } 
        /// <summary>
        /// 项目类型(0普通项目、1零星项目)
        /// </summary>
        [DataMember(Order = 2)]
        public string Type { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [DataMember(Order = 3)]
        public string Name { get; set; }
        /// <summary>
        /// 项目优先级
        /// </summary>
        [DataMember(Order = 4)]
        public string Level { get; set; }
        /// <summary>
        /// 计划开始时间
        /// </summary>
        [DataMember(Order = 5)]
        public string StartTime { get; set; }
        /// <summary>
        /// 用户组编号
        /// </summary>
        [DataMember(Order = 6)]
        public int UserGroupId { get; set; }
        /// <summary>
        /// 文档分类
        /// </summary>
        [DataMember(Order = 7)]
        public int DocCategory { get; set; }
        /// <summary>
        /// 不需要文档分类(0不分类、1分类)
        /// </summary>
        [DataMember(Order = 8)]
        public string NoCategory { get; set; }
        /// <summary>
        /// 项目描述
        /// </summary>
        [DataMember(Order = 9)]
        public string Description { get; set; }
        /// <summary>
        /// 产品列表
        /// </summary>
        //[DataMember(Order = 9)]
        //public List<Product> Products { get; set; }
    }
}
