using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.ProjectManage
{
    /// <summary>
    /// 项目日历业务
    /// </summary>
    [DataContract]
    public class Calendar
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }//项目日历编号
        [DataMember(Order = 2)]
        public int ProjectId { get; set; }//项目名称
        [DataMember(Order = 3)]
        public string Week { get; set; }//一周上班时间
        [DataMember(Order = 4)]
        public string TimeSlot { get; set; }//工作时间端
        [DataMember(Order = 5)]
        public string DateState { get; set; }//被修改的日期和状态的json
    }
}
