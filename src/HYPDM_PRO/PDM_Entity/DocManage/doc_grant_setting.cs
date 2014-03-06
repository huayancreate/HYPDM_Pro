using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{

    [DataContract]
    public class doc_grant_setting
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember(Order = 1)]
        public int id { get; set; }

        /// <summary>
        /// 有效期限
        /// </summary>
        [DataMember(Order = 2)]
        public string valid { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        [DataMember(Order = 3)]
        public string permission_type_name { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        [DataMember(Order = 3)]
        public int permission_type_id { get; set; }

        /// <summary>
        /// 是否默认
        /// </summary>
        [DataMember(Order = 4)]
        public string is_default { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [DataMember(Order = 4)]
        public string valid_time { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [DataMember(Order = 4)]
        public string in_valid_time { get; set; }

        /// <summary>
        /// 发放人
        /// </summary>
        [DataMember(Order = 4)]
        public string grant_by_user { get; set; }

        /// <summary>
        /// 发放目的地
        /// </summary>
        [DataMember(Order = 4)]
        public string grant_user { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        [DataMember(Order = 4)]
        public string grant_type { get; set; }

        /// <summary>
        /// 发放的相关文档
        /// </summary>
        [DataMember(Order = 4)]
        public List<document> document_list { get; set; }


    }
}
