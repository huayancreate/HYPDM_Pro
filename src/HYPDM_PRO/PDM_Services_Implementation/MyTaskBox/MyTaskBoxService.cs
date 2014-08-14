using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Entity.MyTaskBox;
using System.ServiceModel;
using PDM_Services_Interface;
using System.Collections;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class MyTaskBoxService : IMyTaskBoxService
    {
        public List<MyTaskTree> getCheckandSignedTasks()
        {
            var tasks = new List<MyTaskTree>();
            tasks.Add(new MyTaskTree() { ID = 1, Name = "收任务箱" });
            tasks.Add(new MyTaskTree() { ID = 2, Name = "任务管理" });
            tasks.Add(new MyTaskTree() { ID = 3, Name = "已就绪任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 4, Name = "正在执行任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 5, Name = "已完成任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 6, Name = "文档任务", ParentID = 3 });
            tasks.Add(new MyTaskTree() { ID = 7, Name = "BOM任务", ParentID = 3 });
            tasks.Add(new MyTaskTree() { ID = 8, Name = "工艺任务", ParentID = 3 });
            tasks.Add(new MyTaskTree() { ID = 9, Name = "文档任务", ParentID = 4 });
            tasks.Add(new MyTaskTree() { ID = 10, Name = "BOM任务", ParentID = 4 });
            tasks.Add(new MyTaskTree() { ID = 11, Name = "工艺任务", ParentID = 4 });
            tasks.Add(new MyTaskTree() { ID = 12, Name = "文档任务", ParentID = 5 });
            tasks.Add(new MyTaskTree() { ID = 13, Name = "BOM任务", ParentID = 5 });
            tasks.Add(new MyTaskTree() { ID = 14, Name = "工艺任务", ParentID = 5 });
            return tasks;
        }

        public List<MyTaskTree> getOfficeTasks()
        {
            var tasks = new List<MyTaskTree>();
            tasks.Add(new MyTaskTree() { ID = 1, Name = "收任务箱" });
            tasks.Add(new MyTaskTree() { ID = 2, Name = "任务管理" });
            tasks.Add(new MyTaskTree() { ID = 3, Name = "已就绪任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 4, Name = "正在执行任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 5, Name = "已完成任务", ParentID = 1 });
            return tasks;
        }

        public List<MyTaskTree> getProjectTasks()
        {
            var tasks = new List<MyTaskTree>();
            tasks.Add(new MyTaskTree() { ID = 1, Name = "收任务箱" });
            tasks.Add(new MyTaskTree() { ID = 3, Name = "已就绪任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 4, Name = "已挂起任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 5, Name = "正在执行任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 6, Name = "已终止任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 7, Name = "等待申请任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 8, Name = "已完成任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 9, Name = "文档修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 10, Name = "产品结构修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 11, Name = "工艺修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 12, Name = "装配文档修改任务", ParentID = 1 });
            return tasks;
        }

        public List<MyTaskTree> getDesignTasks()
        {
            var tasks = new List<MyTaskTree>();
            tasks.Add(new MyTaskTree() { ID = 1, Name = "收任务箱" });
            tasks.Add(new MyTaskTree() { ID = 2, Name = "任务管理" });
            tasks.Add(new MyTaskTree() { ID = 3, Name = "已就绪任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 4, Name = "已挂起任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 5, Name = "正在执行任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 6, Name = "已终止任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 7, Name = "等待申请任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 8, Name = "已完成任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 9, Name = "文档修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 10, Name = "产品结构修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 11, Name = "历史任务查询", ParentID = 1 });
            return tasks;
        }

        public List<MyTaskTree> getChangeTasks()
        {
            var tasks = new List<MyTaskTree>();
            tasks.Add(new MyTaskTree() { ID = 1, Name = "收任务箱" });
            tasks.Add(new MyTaskTree() { ID = 2, Name = "任务管理" });
            tasks.Add(new MyTaskTree() { ID = 3, Name = "正在执行任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 4, Name = "等待审签任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 5, Name = "变更申请书修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 6, Name = "变更对象修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 7, Name = "已完成任务", ParentID = 1 });
            return tasks;
        }

        public List<MyTaskTree> getCraftTasks()
        {
            var tasks = new List<MyTaskTree>();
            tasks.Add(new MyTaskTree() { ID = 1, Name = "收任务箱" });
            tasks.Add(new MyTaskTree() { ID = 3, Name = "已就绪任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 4, Name = "已挂起任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 5, Name = "正在执行任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 6, Name = "已终止任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 7, Name = "等待申请任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 8, Name = "已完成任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 9, Name = "文档修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 10, Name = "产品结构修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 11, Name = "工艺修改任务", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 12, Name = "装配文档修改任务", ParentID = 1 });
            return tasks;
        }

        public List<MyTaskTree> getToApplyForBusinessTrip()
        {
            var tasks = new List<MyTaskTree>();
            tasks.Add(new MyTaskTree() { ID = 1, Name = "未处理申请" });
            tasks.Add(new MyTaskTree() { ID = 2, Name = "已通过申请" });
            tasks.Add(new MyTaskTree() { ID = 3, Name = "已拒绝申请", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 4, Name = "已提交申请", ParentID = 1 });
            tasks.Add(new MyTaskTree() { ID = 5, Name = "申请管理", ParentID = 1 });
            return tasks;
        }

        public List<CheckSignTask> getCheckandSignedTasksByCondition(Hashtable condition)
        {
            var cst = new List<CheckSignTask>();
            cst.Add(new CheckSignTask() { ID = 1, NodeName = "批准", DocumentCode = "013000001", DocumentVersion = "00", DocumentName = "项目003理想", Submitter = "陈小尼", State = "完成", Type = "项目任务", BelongTask = "立项", BelongProduct = "产品3.1" });
            cst.Add(new CheckSignTask() { ID = 2, NodeName = "结束", DocumentCode = "hy-2226", DocumentVersion = "00", DocumentName = "QQ音乐", Submitter = "刘威", State = "完成", BelongTask = "零星任务", BelongProduct = "产品3.1" });
            return cst;
        }
        public List<TaskNode> getTaskNodesByTaskID(int taskid)
        {
            var tasknodes = new List<TaskNode>();
            tasknodes.Add(new TaskNode() { Sequence = 1, Name = "批准", State = "完成", AuditNumber = "1" });
            return tasknodes;
        }
        public List<Executor> getExecutorByTaskID(int taskid)
        {
            var executors = new List<Executor>();
            executors.Add(new Executor() { Department = "系统管理员", Name = "PDM管理员", AuditState = "完成" });
            return executors;
        }
        public List<NodeProcess> getNodeProcessByTaskID(int taskid)
        {
            var nodeprocess = new List<NodeProcess>();
            nodeprocess.Add(new NodeProcess() { Auditor = "PDM管理员", AuditState = "完成", StartTime = "2014-4-14 17:35:41", EndTime = "2014-4-14 17:36:37" });
            return nodeprocess;
        }
        public List<OfficeTask> getOfficeTasksByCondition(Hashtable condition)
        {
            var cst = new List<OfficeTask>();
            cst.Add(new OfficeTask() { ID = 1, NodeName = "批准", DocumentCode = "013000001", DocumentVersion = "00", DocumentName = "项目003理想", Submitter = "陈小尼", State = "完成", Type = "项目任务", BelongTask = "立项", BelongProduct = "产品3.1" });
            cst.Add(new OfficeTask() { ID = 2, NodeName = "结束", DocumentCode = "hy-2226", DocumentVersion = "00", DocumentName = "QQ音乐", Submitter = "刘威", State = "完成", BelongTask = "零星任务", BelongProduct = "产品3.1" });
            return cst;
        }
        public List<Taskbo> getProjectTasksByTaskType(int type)
        {
            var cst = new List<Taskbo>();
            cst.Add(new Taskbo() { ID = 1, BelongTask = "6688", BelongProduct = "", Name = "6688", Creator = "PDM管理员", Executor = "陈小尼", State = "执行" });
            cst.Add(new Taskbo() { ID = 2, BelongTask = "009", BelongProduct = "", Name = "009", Creator = "陈小尼", Executor = "PDM管理员", State = "执行" });
            return cst;
        }
        public List<Taskbo> getDesignTasksByTaskType(int type)
        {
            var cst = new List<Taskbo>();
            cst.Add(new Taskbo() { ID = 1, Name = "1", BelongTask = "proe2", Creator = "PDM管理员", Executor = "陈小尼", State = "完成" });
            return cst;
        }
        public List<Taskbo> getChangeTasksByTaskType(int type)
        {
            var cst = new List<Taskbo>();
            return cst;
        }
        public List<Taskbo> getCraftTasksByTaskType(int type)
        {
            var cst = new List<Taskbo>();
            cst.Add(new Taskbo() { ID = 1, Name = "www", Creator = "PDM管理员", PlanStartTime = "2010-07-21 17:30:05", PlanEndTime = "2010-07-28 17:30:40" });
            cst.Add(new Taskbo() { ID = 2, Name = "www", Creator = "PDM管理员", PlanStartTime = "2010-07-21 17:31:02", PlanEndTime = "2010-07-28 17:31:37" });
            return cst;
        }
        public Taskbo getTaskById(int id)
        {
            var task = new Taskbo()
            {
                ID = 1,
                Name = "0909",
                Creator = "陈小尼",
                Percent = 80,
                PlanStartTime = "2010-07-21 17:30:05",
                PlanEndTime = "2010-07-28 17:30:40",
                StartTime = "2010-07-21 17:30:05",
                EndTime = "2010-07-28 17:30:40",
                State = "XX任务",
                BelongTask = "00",
                BelongProduct = "A-02",
                BelongProject = "AQ-001",
                Executor = "陈小尼",
                WarningPercentage = "80%",
                WarningTime = "2010-07-28 17:30:40",
                WhetherItCanDecompose = "能",
                Description = "AAAAAAAA",
                Remark = "BBBBBB"
            };
            return task;
        }
        public List<TreeNode> getEmailTree()
        {
            var tree = new List<TreeNode>();
            tree.Add(new TreeNode() { ID = 1, Name = "陈小尼" });
            tree.Add(new TreeNode() { ID = 2, Name = "历史数据查询" });
            tree.Add(new TreeNode() { ID = 3, ParentID = 1, Name = "收件箱" });
            tree.Add(new TreeNode() { ID = 4, ParentID = 1, Name = "草稿箱" });
            tree.Add(new TreeNode() { ID = 5, ParentID = 1, Name = "发件箱" });
            return tree;
        }
        public List<Email> getMailReceivingByMyID(int id)
        {
            var emails = new List<Email>();
            emails.Add(new Email() { ID = 1, Topic = "您有一个文档审签通过", Signed = "N", Sender = "PDM管理员<administrator@pdm.com>", Recipients = "陈小尼<xnchen@pdm.com>", SendTime = "2010-07-26 15:09:42", Size = "0.2k" });
            emails.Add(new Email() { ID = 1, Topic = "您有一个BOM结构被打回,请修改", Signed = "O", Sender = "PDM管理员<administrator@pdm.com>", Recipients = "陈小尼<xnchen@pdm.com>", SendTime = "2010-07-26 15:09:42", Size = "0.2k" });
            return emails;
        }
        public Email GetEmailByID(int id)
        {
            return new Email() { ID = 1, Topic = "您有一个文档审签通过", Signed = "N", Sender = "PDM管理员", Saddress = "administrator@pdm.com", Recipients = "陈小尼", Raddress = "xnchen@pdm.com", Body = "您好,您有一个名为<1>(编号:112200,版本:00)的文档审签通过.", SendTime = "2010-07-26 15:09:42", Size = "0.2k" };
        }
        public void RemoveEmailByID(int id)
        {

        }
        public List<Email> SearchEmailByContent(string content)
        {
            return getMailReceivingByMyID(1).Where(email => email.Topic.Contains(content)).ToList<Email>(); ;
        }
        public void SaveEmailByMyID(int id)
        {

        }
        public void SendEmailByMyID(int id)
        {

        }
        public List<Bulletin> GetBulletinAll()
        {
            var bolletins = new List<Bulletin>();
            bolletins.Add(new Bulletin() { ID = 1, Title = "国庆节放假通知", Body = "国庆节就要到了，根据国家法定节假日规定，2013年国庆节节放假时间定为10月1日至7日放假，共7天，10月12日（周六）上班，望大家遵守规定，按时到岗上班；外派人员需听从客户公司安排，如有调休或者其他特殊情况，请及时向公司告知。介于国庆节假日外出人员过多，大家回家、出外游玩一定要注意自身安全。\n\r    祝:国庆节快乐", Department = "研发部", Sign = "N", PublishTime = "2014-4-14 11:31:52" });
            bolletins.Add(new Bulletin() { ID = 2, Title = "新规定通知", Body = "呵呵.", Department = "研发部", Sign = "O", PublishTime = "2014-4-14 11:32:50" });
            return bolletins;
        }
        public Bulletin GetBulletinByID(int id)
        {
            return GetBulletinAll().Where(b => b.ID == id).ToList<Bulletin>()[0];
        }
        public List<Question> GetQuestionAll()
        {
            var questions = new List<Question>();
            questions.Add(new Question()
            {
                ID = 1,
                Title = "劳动节放假通知",
                Body = "亲们,劳动节按法定节假日放假,如有加班请提交申请.",
                Creator = "陈小尼",
                Email = "xnchen@pdm.com",
                Sign = "N",
                CreateTime = "2014-4-14 11:31:52",
                replies = new List<Reply>() { 
                    new Reply(){ ID=1,Body="好耶!",Creator="阿辉",Email="ahui@pdm.com",CreateTime="2014-4-14 11:41:53" },
                    new Reply(){ ID=2,Body="能不能多放几天,亲!",Creator="阿亮",Email="aliang@pdm.com",CreateTime="2014-4-14 11:42:33" },
                    new Reply(){ ID=3,Body="不要命了,我才不加班.",Creator="阿蓝",Email="alan@pdm.com",CreateTime="2014-4-14 11:43:43" }
                }
            });
            questions.Add(new Question() { ID = 1, Title = "新规定通知", Body = "呵呵.", Creator = "陈小尼", Email = "xnchen@pdm.com", Sign = "O", CreateTime = "2014-4-14 11:32:50" });
            return questions;
        }
        public Question GetQuestionByID(int id)
        {
            return new Question()
            {
                ID = 1,
                Title = "劳动节放假通知",
                Body = "亲们,劳动节按法定节假日放假,如有加班请提交申请.",
                Creator = "陈小尼",
                Email = "xnchen@pdm.com",
                Sign = "N",
                CreateTime = "2014-4-14 11:31:52",
                replies = new List<Reply>() { 
                    new Reply(){ ID=1,Body="好耶!",Creator="阿辉",Email="ahui@pdm.com",CreateTime="2014-4-14 11:41:53" },
                    new Reply(){ ID=2,Body="能不能多放几天,亲!",Creator="阿亮",Email="aliang@pdm.com",CreateTime="2014-4-14 11:42:33" },
                    new Reply(){ ID=3,Body="不要命了,我才不加班.",Creator="阿蓝",Email="alan@pdm.com",CreateTime="2014-4-14 11:43:43" }
                }
            };
        }
        public List<ChangeNotification> GetChangeNotificationAll()
        {
            return new List<ChangeNotification>()
            {
                new ChangeNotification(){ID=1,Code = "20bxbx00",Version="00",Name="变更申请",Sendor="白柏雄",SendTime="2010-07-21 17:25:47"},
                new ChangeNotification(){ID=2,Code = "01-123000",Version="00",Name="10000",Sendor="管理员",SendTime="2010-07-22 19:18:08"},
                new ChangeNotification(){ID=3,Code = "01-123005",Version="00",Name="0333(1)",Sendor="管理员",SendTime="2010-07-21 20:35:08"},
                new ChangeNotification(){ID=4,Code = "200724001",Version="00",Name="$4~A}$ZADL",Sendor="董长丽",SendTime="2010-07-24 11:02:47"},
                new ChangeNotification(){ID=5,Code = "200724002",Version="00",Name="07152401",Sendor="管理员",SendTime="2010-07-24 11:19:47"},
                new ChangeNotification(){ID=6,Code = "200724003",Version="00",Name="变更申请200724003",Sendor="董长丽",SendTime="2010-07-24 11:19:47"},
                new ChangeNotification(){ID=7,Code = "200724004",Version="00",Name="变更申请200724004",Sendor="白柏雄",SendTime="2010-07-24 11:19:47"},
            };
        }
        public List<ChangeNotification> GetChangeNotificationByConditions(Hashtable conditions)
        {
            return GetChangeNotificationAll();
        }
        public List<Document> GetChangeDocumentByChangeNotificationID(int id)
        {
            return new List<Document>()
            {
                new Document(){ID = 1,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
                new Document(){ID = 2,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
                new Document(){ID = 3,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
                new Document(){ID = 4,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
                new Document(){ID = 5,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
                new Document(){ID = 6,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
                new Document(){ID = 7,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
                new Document(){ID = 8,Extension="GIF",Type="变更后文档",Code = "400724000",Name="0720001",Version="00",EffectTime="2010-07-24 14:42:04"},
            };
        }
        public List<ChangeStructure> GetChangeStructureByChangeNotificationID(int id)
        {
            return new List<ChangeStructure>(){
                new ChangeStructure(){ID=1,PartCode="YB0000003",PartVersion="01",OldPartCode="YB0000003",OldPartVersion="00"},
            };
        }

        public List<Document> GetMyDocumentByConditions(Hashtable conditions)
        {
            return new List<Document>()
            {
                new Document(){ID=1,Code="TYL0001017",Version="00",Name="专业版第二轮测试",Type="kong",GrantTime="2010-07-26",Creator="007",GrantPermissions="浏览",State="O"},
                new Document(){ID=2,Code="01EEEE0000",Version="00",Name="导出单位",Type="kong",GrantTime="2010-07-26",Creator="马顺华",GrantPermissions="浏览",State="U"},
                new Document(){ID=3,Code="02CCCC0005",Version="00",Name="集成测试要点_U9集成",Type="项目文档管里",GrantTime="2010-07-26",Creator="王勇",GrantPermissions="浏览",State="R"},
            };
        }
        public List<TreeNode> GetRolesByUserID(int id)
        {
            return new List<TreeNode>() { 
                new TreeNode(){ID=1,Name="非项目角色"},
                new TreeNode(){ID=2,Name="项目角色"},
                new TreeNode(){ID=3,Name="系统管理员",ParentID=1},
                new TreeNode(){ID=4,Name="项目专用角色",ParentID=1},
                new TreeNode(){ID=5,Name="基本人员权限",ParentID=1},
                new TreeNode(){ID=6,Name="文档变更",ParentID=1},
                new TreeNode(){ID=7,Name="项目管理",ParentID=1},
                new TreeNode(){ID=8,Name="结构管理",ParentID=1},
                new TreeNode(){ID=9,Name="需求人员",ParentID=2},
                new TreeNode(){ID=10,Name="项目经理",ParentID=2},
            };
        }
        public void ChangePasswordByUserID(int id, string password) 
        { 
            //TODO: ChangePassword Code.
        }
        public void SettingUserInfomation(User user)
        { 
            //TODO: Update user information by User object.
        }
        public List<Code> GetCodesByConditions(Hashtable conditions) 
        {
            return new List<Code>() { 
                new Code(){ID=1,Coding="0232MISCB00",Name="MILIN",Applicant="陈小尼",ApplicationTime="2014-05-13 10:17:25",State="未使用",CodingScheme=""},
                new Code(){ID=1,Coding="0232MISCB01",Name="MITINTO 3",Applicant="陈小尼",ApplicationTime="2014-05-13 10:17:25",State="未使用",CodingScheme=""},
                new Code(){ID=1,Coding="0232MISCB02",Name="MITINTO 3",Applicant="陈小尼",ApplicationTime="2014-05-13 10:32:27",State="未使用",CodingScheme=""},
                new Code(){ID=1,Coding="0232MISCB03",Name="MITINTO 3",Applicant="陈小尼",ApplicationTime="2014-05-13 10:32:43",State="未使用",CodingScheme=""},
                new Code(){ID=1,Coding="0232MISCB04",Name="MITINTO 3",Applicant="陈小尼",ApplicationTime="2014-05-13 10:33:02",State="未使用",CodingScheme=""},
                new Code(){ID=1,Coding="0232MISCB05",Name="213123123",Applicant="陈小尼",ApplicationTime="2014-05-13 10:33:11",State="未使用",CodingScheme=""},
                new Code(){ID=1,Coding="0232MISCB06",Name="123123123",Applicant="陈小尼",ApplicationTime="2014-05-13 10:33:22",State="未使用",CodingScheme=""},
            };
        }
        public Code GetCodeByID(int id) {
            return new Code(){ID=1,Coding="0232MISCB00",Name="MILIN",Applicant="陈小尼",ApplicationTime="2014-05-13 10:17:25",State="未使用",CodingScheme=""};
        }
        public void ApplicationCodeByUserID(Hashtable conditions) { 
            //TODO 保存编码
        }
        public void ModifyCode(Hashtable code) { 
            //TODO 修改编码
        }
    }
}