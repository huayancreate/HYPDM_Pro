using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{

    [DataContract]
    public class doc_template
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
        /// 名称
        /// </summary>
        [DataMember(Order = 1)]
        public string name { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [DataMember(Order = 3)]
        public int parent_id { get; set; }

        /// <summary>
        /// 父名称
        /// </summary>
        [DataMember(Order = 4)]
        public string parent_name { get; set; }

        /// <summary>
        /// 物理物件位置
        /// </summary>
        [DataMember(Order = 5)]
        public string physical_file_location { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [DataMember(Order = 6)]
        public string type { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [DataMember(Order = 14)]
        public string breadth { get; set; }

        /// <summary>
        /// 修改次数
        /// </summary>
        [DataMember(Order = 15)]
        public string modify_count { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [DataMember(Order = 15)]
        public string file_type { get; set; }
    }
}
