using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{

    [DataContract]
    public class document_type
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember(Order = 1)]
        public int id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [DataMember(Order = 2)]
        public string name { get; set; }

        /// <summary>
        /// 父亲id
        /// </summary>
        [DataMember(Order = 3)]
        public int parent_id { get; set; }

        /// <summary>
        /// 是否有子节点
        /// </summary>
        [DataMember(Order = 4)]
        public bool is_leaf { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [DataMember(Order = 5)]
        public List<doc_attached_property> DocProperty { get; set; }
    }
}
