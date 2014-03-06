using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{
    [DataContract]
    public class doc_query
    {
        /// <summary>
        /// 文档编号	
        /// </summary>
        [DataMember(Order = 1)]
        public int number { get; set; }

        /// <summary>
        /// 文档版本	
        /// </summary>
        [DataMember(Order = 1)]
        public string version { get; set; }


        /// <summary>
        /// 文档名称
        /// </summary>
        [DataMember(Order = 1)]
        public string cn_name { get; set; }

        /// <summary>
        ///  文档类型id
        /// </summary>
        [DataMember(Order = 16)]
        public int document_type_id { get; set; }

        /// <summary>
        /// 文档类型名称
        /// </summary>
        [DataMember(Order = 17)]
        public string document_type_name { get; set; }

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
        /// 文档摘要	
        /// </summary>
        [DataMember(Order = 1)]
        public string abstract_content { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [DataMember(Order = 1)]
        public string key { get; set; }

        /// <summary>
        /// 文档所属项目
        /// </summary>
        [DataMember(Order = 1)]
        public int genus_project { get; set; }

        /// <summary>
        /// 文档所属产品	
        /// </summary>
        [DataMember(Order = 1)]
        public string genus_product { get; set; }

        /// <summary>
        /// 文档所属任务
        /// </summary>
        [DataMember(Order = 1)]
        public string genus_task { get; set; }

        /// <summary>
        /// 文档权限
        /// </summary>
        [DataMember(Order = 1)]
        public string authority { get; set; }

        /// <summary>
        /// 文档状态 	
        /// </summary>
        [DataMember(Order = 1)]
        public string status { get; set; }

       
    }
}
