using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Services_Interface;
using PDM_Entity.ProjectManage;
using Newtonsoft.Json;
using System.IO;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ProjectCalendarService : IProjectCalendarService
    {
        public List<WorkTimeBo> getWorkTimesByProjectId(int id)
        {
            List<WorkTimeBo> worktimes = new List<WorkTimeBo>();
            WorkTimeBo wt1 = new WorkTimeBo();
            wt1.Start = "09:00";
            wt1.End = "12:00";
            WorkTimeBo wt2 = new WorkTimeBo();
            wt2.Start = "13:00";
            wt2.End = "18:00";
            WorkTimeBo wt3 = new WorkTimeBo();
            WorkTimeBo wt4 = new WorkTimeBo();
            worktimes.Add(wt1);
            worktimes.Add(wt2);
            worktimes.Add(wt3);
            worktimes.Add(wt4);
            return worktimes;
        }
        public ProjectCalendarBo getProjectCalendarByProjectId(int id)
        {
            ProjectCalendarBo projectcalendar = new ProjectCalendarBo();
            projectcalendar.Id = 1;
            projectcalendar.ProjectName = "杀猪";
            projectcalendar.StartTime = "2014-02-26 08:30:00";
            string week = "{Sunday:false,Monday:true,Tuesday:true,Wednesday:true,Thursday:true,Friday:true,Saturday:false}";
            projectcalendar.Week = JavaScriptConvert.DeserializeObject<WeekBo>(week);
            string worktime = "[{Start:'09:00',End:'12:00'},{Start:'13:00',End:'18:00'},{Start:'',End:''},{Start:'',End:''}]";
            projectcalendar.TimeSlot = JavaScriptConvert.DeserializeObject<List<WorkTimeBo>>(worktime);
            string workdate = "[{Time:'2014-2-2',State:'班'},{Time:'2014-2-1',State:'班'}]";
            projectcalendar.DateState = JavaScriptConvert.DeserializeObject<List<WorkDateBo>>(workdate);
            return projectcalendar;
        }
        public bool saveProjectCalendarByProjectId(ProjectCalendarBo projectcalendar, int id)
        {
            Calendar cal = new Calendar();
            cal.ProjectId = id;
            cal.Week = JavaScriptConvert.SerializeObject(projectcalendar.Week);
            cal.TimeSlot = JavaScriptConvert.SerializeObject(projectcalendar.TimeSlot);
            //保存代码
            return false;
        }
        public bool saveAllProjectCalendarByProjectId(ProjectCalendarBo projectcalendar, int id)
        {
            Calendar cal = new Calendar();
            cal.ProjectId = id;
            cal.Week = JavaScriptConvert.SerializeObject(projectcalendar.Week);
            cal.TimeSlot = JavaScriptConvert.SerializeObject(projectcalendar.TimeSlot);
            cal.DateState = JavaScriptConvert.SerializeObject(projectcalendar.DateState);
            //保存代码
            return false;
        }
        /// <summary>
        /// 把设置保存成默认值
        /// </summary>
        /// <param name="projectcalendar"></param>
        /// <returns></returns>
        public bool setProjectCalendarToDefault(ProjectCalendarBo projectcalendar)
        {
            try
            {
                if (!Directory.Exists(@".\Settings"))//判断文件夹是否已经存在
                {
                    Directory.CreateDirectory(@".\Settings");//创建文件夹
                }
                StreamWriter file = new StreamWriter(@"Settings\Calendar.ini");
                file.WriteLine("Week=" + JavaScriptConvert.SerializeObject(projectcalendar.Week));
                file.WriteLine("Time=" + JavaScriptConvert.SerializeObject(projectcalendar.TimeSlot));
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public ProjectCalendarBo setProjectCalendarFromDefault()
        {
            return null;
        }
    }
}
