using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Services_Interface;
using PDM_Entity.ProjectManage;
using System.Collections;

namespace PDM_Services_Implementation
{
    /// <summary>
    /// 项目列表,由项目列表/条件查询/项目分组结构
    /// </summary>
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class ProjectExportService : IProjectExportService
    {
        /// <summary>
        /// 获取项目类型列表
        /// </summary>
        /// <returns></returns>
        public List<ProjectTypeBo> getAllProjectTypes() { 
            List<ProjectTypeBo> projectTypes = new List<ProjectTypeBo>();
            ProjectTypeBo pt1 = new ProjectTypeBo();
            pt1.Id = 1;
            pt1.Name = "20110110";
            ProjectTypeBo pt2 = new ProjectTypeBo();
            pt2.Id = 2;
            pt2.Name = "20110210";
            ProjectTypeBo pt3 = new ProjectTypeBo();
            pt3.Id = 3;
            pt3.Name = "20110210";
            pt3.ParentId = 1;
            projectTypes.Add(pt1);
            projectTypes.Add(pt2);
            projectTypes.Add(pt3);
            return projectTypes;
        }

        public List<ProjectBo> getAllProjects() 
        {
            List<ProjectBo> projects = new List<ProjectBo>();
            ProjectBo p1 = new ProjectBo();
            p1.Id = 1;
            p1.Name = "杀猪100头";
            p1.GroupName = "宰杀组";
            p1.State = "实例化就绪";
            p1.StartTime = "2014-02-25 08:30";
            p1.EndTime = "2014-02-25 17:30";
            projects.Add(p1);
            return projects;
        }

        public List<ProjectBo> getProjectsBySomeField(Hashtable condition) {
            List<ProjectBo> projects = new List<ProjectBo>();
            ProjectBo p1 = new ProjectBo();
            p1.Id = 1;
            p1.Name = "杀猪80头";
            p1.GroupName = "宰杀组";
            p1.State = "实例化就绪";
            p1.StartTime = "2014-02-25 08:30";
            p1.EndTime = "2014-02-25 17:30";
            projects.Add(p1);
            return projects;
        }
        public List<ProjectBo> getProjectsByGroupId(int groupid)
        {
            List<ProjectBo> projects = new List<ProjectBo>();
            ProjectBo p1 = new ProjectBo();
            p1.Id = 1;
            p1.Name = "杀猪90头";
            p1.GroupName = "宰杀组";
            p1.State = "实例化就绪";
            p1.StartTime = "2014-02-25 08:30";
            p1.EndTime = "2014-02-25 17:30";
            projects.Add(p1);
            return projects;
        }
    }
}
