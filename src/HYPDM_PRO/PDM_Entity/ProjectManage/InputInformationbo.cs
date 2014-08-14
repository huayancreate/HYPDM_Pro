using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 输入信息
    /// </summary>
    public class InputInformationbo
    {
        public int Id { get; set; }//编号
        public string Filename { get; set; }//文件名称
        public string Pathname { get; set; }//文件路径
        public string Format { get; set; }//文件格式
        public string Name { get; set; }//
        public string Type { get; set; }//文件类型
    }
}
