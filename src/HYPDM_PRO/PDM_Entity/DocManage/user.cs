using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.DocManage
{
    [DataContract]
    public  class user
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [DataMember(Order = 1)]
        public int id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [DataMember(Order = 1)]
        public string name { get; set; }

        /// <summary>
        /// 用户部门
        /// </summary>
        [DataMember(Order = 1)]
        public int department_id { get; set; }

        /// <summary>
        /// 用户部门名称
        /// </summary>
        [DataMember(Order = 1)]
        public string department_name { get; set; }
    }
}
