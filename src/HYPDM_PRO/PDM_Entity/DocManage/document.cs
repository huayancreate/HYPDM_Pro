using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace PDM_Entity.DocManage
{
    [DataContract]
    public class document
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
        /// 修改次数
        /// </summary>
        [DataMember(Order = 8)]
        public string modify_count { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [DataMember(Order = 1)]
        public string is_delete { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [DataMember(Order = 8)]
        public string number { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [DataMember(Order = 8)]
        public string version { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        [DataMember(Order = 8)]
        public string en_name { get; set; }

        /// <summary>
        /// 中文名
        /// </summary>
        [DataMember(Order = 8)]
        public string cn_name { get; set; }

        /// <summary>
        /// 格式id
        /// </summary>
        [DataMember(Order = 9)]
        public int format_id { get; set; }

        /// <summary>
        /// 格式名称
        /// </summary>
        [DataMember(Order = 10)]
        public string format_name { get; set; }

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
        /// 文档页面
        /// </summary>
        [DataMember(Order = 8)]
        public string doc_page { get; set; }
        
        /// <summary>
        /// 文档物理位置
        /// </summary>
        [DataMember(Order = 8)]
        public string physical_file_location { get; set; }

        /// <summary>
        /// 文档模板id
        /// </summary>
        [DataMember(Order = 13)]
        public int doc_template_id { get; set; }

        /// <summary>
        /// 文档模板名称
        /// </summary>
        [DataMember(Order = 14)]
        public string doc_template_name { get; set; }

        /// <summary>
        /// 文档密级id
        /// </summary>
        [DataMember(Order = 11)]
        public int dense_id { get; set; }

        /// <summary>
        /// 文档密级
        /// </summary>
        [DataMember(Order = 12)]
        public string dense_name { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [DataMember(Order = 12)]
        public string valid_time { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [DataMember(Order = 12)]
        public string in_valid_time { get; set; }

        /// <summary>
        /// 文档状态
        /// </summary>
        [DataMember(Order = 15)]
        public string status { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [DataMember(Order = 15)]
        public string key { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DataMember(Order = 15)]
        public string remark { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [DataMember(Order = 15)]
        public string abstract_content { get; set; }

        /// <summary>
        ///  子文档
        /// </summary>
        [DataMember(Order = 15)]
        public List<document> sub_document { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column1 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column2 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column3 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column4 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column5 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column6 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column7 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column8 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column9 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column10 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column11 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column12 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column13 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column14 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column15 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column16 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column17 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column18 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column19 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column20 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column21 { get; set; }

        /// <summary>
        /// column 扩展属性
        /// </summary>
        [DataMember(Order = 18)]
        public string column22 { get; set; }

        /// <summary>
        /// checkbox选中
        /// </summary>
        [DataMember(Order = 18)]
        public bool gridControlCheck { get; set; }

        /// <summary>
        ///格式缩图 文件流
        /// </summary>
        [DataMember(Order = 18)]
        public byte[] format_pic { get; set; }

        /// <summary>
        /// ip地址
        /// </summary>
        [DataMember(Order = 18)]
        public string ipaddress { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        [DataMember(Order = 18)]
        public int port { get; set; }

       
    }
}
