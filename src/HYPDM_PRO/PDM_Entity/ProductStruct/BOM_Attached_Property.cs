using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.ProductStruct
{
    /// <summary>
    /// BOM附加属性表
    /// </summary>
    [DataContract]
    public class BOM_Attached_Property
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// 中文名称
        /// </summary>
        [DataMember]
        public string CN_Name { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        [DataMember]
        public string EN_Name { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        [DataMember]
        public string DataType { get; set; }
        /// <summary>
        /// 数据长度
        /// </summary>
        [DataMember]
        public string DataLength { get; set; }
        /// <summary>
        /// 录入方式
        /// </summary>
        [DataMember]
        public string InputType { get; set; }
        /// <summary>
        /// 是否必填 [ 0:可以为空 1:必填 ]
        /// </summary>
        [DataMember]
        public string Required { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        [DataMember]
        public string DefaultValue { get; set; }
        /// <summary>
        /// 是否是查询条件 [ 0:否 1:是 ]
        /// </summary>
        [DataMember]
        public string Is_Query { get; set; }
        /// <summary>
        /// 显示宽度[像素]
        /// </summary>
        [DataMember]
        public string Width { get; set; }
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
