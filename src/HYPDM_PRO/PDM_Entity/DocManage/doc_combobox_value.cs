using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{
    
    [DataContract]
    public class doc_combobox_value
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
        public string modify_user_name { get; set; }

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
        /// 属性id
        /// </summary>
        [DataMember(Order = 1)]
        public int doc_attached_peoperty_id { get; set; }

        /// <summary>
        /// 下拉框值
        /// </summary>
        [DataMember(Order = 1)]
        public string  value { get; set; }
    }
}
