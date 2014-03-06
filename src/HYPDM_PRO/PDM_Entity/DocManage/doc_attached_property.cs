using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{
    [DataContract]
    public class doc_attached_property
    {
        /// <summary>
        /// ID	
        /// </summary>
        [DataMember(Order = 1)]
        public int id { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [DataMember(Order = 1)]
        public int create_user_id { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [DataMember(Order = 1)]
        public string create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DataMember(Order = 1)]
        public DateTime create_date { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [DataMember(Order = 1)]
        public int modify_user_id { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        [DataMember(Order = 1)]
        public string  modify_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [DataMember(Order = 1)]
        public DateTime modify_date { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [DataMember(Order = 1)]
        public string is_delete { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [DataMember(Order = 1)]
        public string order { get; set; }

        /// <summary>
        /// 中文名称
        /// </summary>
        [DataMember(Order = 1)]
        public string cn_name { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [DataMember(Order = 1)]
        public string  en_name { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [DataMember(Order = 1)]
        public string data_type { get; set; }

        /// <summary>
        /// 数据长度
        /// </summary>
        [DataMember(Order = 1)] 
        public string  data_length { get; set; }

        /// <summary>
        /// 录入方式
        /// </summary>
        [DataMember(Order = 1)]
        public string
        input_type { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [DataMember(Order = 1)]
        public string required { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [DataMember(Order = 1)]
        public string  default_value { get; set; }

        /// <summary>
        /// 子类分类是否继承
        /// </summary>
        [DataMember(Order = 1)]
        public string  is_extends { get; set; }

        /// <summary>
        /// 是否是查询条件
        /// </summary>
        [DataMember(Order = 1)]
        public string is_query { get; set; }

        /// <summary>
        /// 属性类型
        /// </summary>
        [DataMember(Order = 1)]
        public string property_type { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [DataMember(Order = 1)]
        public bool is_display { get; set; }

        /// <summary>
        /// 显示宽度
        /// </summary>
        [DataMember(Order = 1)]
        public string display_width { get; set; }

        /// <summary>
        /// 是否自定义
        /// </summary>
        [DataMember(Order = 1)]
        public string is_user_define { get; set; }

        /// <summary>
        /// 如果是下拉框，下拉框的值集合
        /// </summary>
        [DataMember(Order = 23)]
        public List<doc_combobox_value> ComboxValue { get; set; }

        /***
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public string CnName { get; set; }

        [DataMember(Order = 3)]
        public string EnName { get; set; }

        [DataMember(Order = 4)]
        public string DataType { get; set; }

        [DataMember(Order = 5)]
        public string DataLength { get; set; }

        [DataMember(Order = 6)]
        public string InputType { get; set; }

        [DataMember(Order = 7)]
        public string Required { get; set; }

        [DataMember(Order = 8)]
        public string Default { get; set; }

        [DataMember(Order = 9)]
        public string IsExtends { get; set; }

        [DataMember(Order = 10)]
        public string IsQuery { get; set; }

        [DataMember(Order = 11)]
        public string Width { get; set; }

        [DataMember(Order = 12)]
        public string PropertyType { get; set; }

        [DataMember(Order = 13)]
        public string IsDelete { get; set; }

        [DataMember(Order = 14)]
        public string CreateUserId { get; set; }

        [DataMember(Order = 15)]
        public string CreateUser { get; set; }

        [DataMember(Order = 16)]
        public string CreateDate { get; set; }

        [DataMember(Order = 17)]
        public string ModifyUser { get; set; }

        [DataMember(Order = 18)]
        public string ModifyUserId { get; set; }

        [DataMember(Order = 19)]
        public string ModifyDate { get; set; }

        [DataMember(Order = 20)]
        public Boolean IsDisplay { get; set; }

        [DataMember(Order = 21)]
        public string IsUserDefine { get; set; }

        [DataMember(Order = 23)]
        public List<DocComBoBoxValue> ComboxValue { get; set; }

        [DataMember(Order = 22)]
        public int Order { get; set; }

        
        **/
    }
}
