using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.MyTaskBox;
using System.Collections;

namespace PDM_Services_Interface
{
    /// <summary>
    /// 我的任务箱接口
    /// </summary>
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMyTaskBoxService
    {
        /// <summary>
        /// 获取审签任务树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MyTaskTree> getCheckandSignedTasks();
        /// <summary>
        /// 获取办公任务树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MyTaskTree> getOfficeTasks();
        /// <summary>
        /// 获取项目任务树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MyTaskTree> getProjectTasks();
        /// <summary>
        /// 获取设计任务树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MyTaskTree> getDesignTasks();
        /// <summary>
        /// 获取变更任务树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MyTaskTree> getChangeTasks();
        /// <summary>
        /// 获取工艺任务树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MyTaskTree> getCraftTasks();
        /// <summary>
        /// 获取出差申请树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<MyTaskTree> getToApplyForBusinessTrip();
        /// <summary>
        /// 获取任务列表,根据文档编号、文档版本、文档名称、任务创建时间获取任务列表
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<CheckSignTask> getCheckandSignedTasksByCondition(Hashtable condition);
        /// <summary>
        /// 获取任务节点,根据任务编号获取任务节点
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        [OperationContract]
        List<TaskNode> getTaskNodesByTaskID(int taskid);
        /// <summary>
        /// 获取执行人,根据任务编号获取执行人
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        [OperationContract]
        List<Executor> getExecutorByTaskID(int taskid);
        /// <summary>
        /// 获取审签节点过程信息,根据任务编号获取审签节点过程信息
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        [OperationContract]
        List<NodeProcess> getNodeProcessByTaskID(int taskid);
        /// <summary>
        /// 获取办公任务列表,根据文档编号、文档版本、文档名称、任务创建时间获取任务列表
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<OfficeTask> getOfficeTasksByCondition(Hashtable condition);
        /// <summary>
        /// 获取办公任务列表,根据文档编号、文档版本、文档名称、任务创建时间获取任务列表
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Taskbo> getProjectTasksByTaskType(int type);
        /// <summary>
        /// 获取设计任务列表
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [OperationContract]
        List<Taskbo> getDesignTasksByTaskType(int type);
        /// <summary>
        /// 获取变更任务列表
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [OperationContract]
        List<Taskbo> getChangeTasksByTaskType(int type);
        /// <summary>
        /// 获取设计任务列表
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [OperationContract]
        List<Taskbo> getCraftTasksByTaskType(int type);
        /// <summary>
        /// 获取任务,根据任务编号获取任务
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [OperationContract]
        Taskbo getTaskById(int id);
        /// <summary>
        /// 获取邮箱左侧树
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<TreeNode> getEmailTree();
        /// <summary>
        /// 根据用户编号获取邮件
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Email> getMailReceivingByMyID(int id);
        /// <summary>
        /// 根据邮件编号获取邮件
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        Email GetEmailByID(int id);
        /// <summary>
        /// 根据邮件编号删除邮件
        /// </summary>
        [OperationContract]
        void RemoveEmailByID(int id);
        /// <summary>
        /// 根据邮件内容查找符合条件的邮件
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Email> SearchEmailByContent(string content);
        /// <summary>
        /// 保存邮件
        /// </summary>
        /// <param name="id">用户编号</param>
        [OperationContract]
        void SaveEmailByMyID(int id);
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="id">用户编号</param>
        [OperationContract]
        void SendEmailByMyID(int id);
        /// <summary>
        /// 获取所有公告
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Bulletin> GetBulletinAll();
        /// <summary>
        /// 获取公告,根据公告编号获取公告
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        Bulletin GetBulletinByID(int id);
        /// <summary>
        /// 获取所有问题
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Question> GetQuestionAll();
        /// <summary>
        /// 获取问题,根据问题编号获取问题
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        Question GetQuestionByID(int id);
        /// <summary>
        /// 获取所有变更通知
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<ChangeNotification> GetChangeNotificationAll();
        /// <summary>
        /// 获取变更通知,根据查询条件获取变更管通知
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        [OperationContract]
        List<ChangeNotification> GetChangeNotificationByConditions(Hashtable conditions);
        /// <summary>
        /// 获取变更文档,根据据变更通知编号获取变更文档
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<Document> GetChangeDocumentByChangeNotificationID(int id);
        /// <summary>
        /// 获取变更结构,根据据变更通知编号获取变更结构
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<ChangeStructure> GetChangeStructureByChangeNotificationID(int id);
        /// <summary>
        /// 获取我的文档列表,根据相关条件查询文档列表
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        [OperationContract]
        List<Document> GetMyDocumentByConditions(Hashtable conditions);
        /// <summary>
        /// 获取角色列表,根据用户编号
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [OperationContract]
        List<TreeNode> GetRolesByUserID(int id);
        /// <summary>
        /// 根据用户编号修改密码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        [OperationContract]
        void ChangePasswordByUserID(int id, string password);
        /// <summary>
        /// 设置用户信息
        /// </summary>
        /// <param name="user"></param>
        [OperationContract]
        void SettingUserInfomation(User user);
        /// <summary>
        /// 获取编码列表,根据编码相关属性获取编码列表
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        [OperationContract]
        List<Code> GetCodesByConditions(Hashtable conditions);
        /// <summary>
        /// 获取编码,根据编码编号获取编码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        Code GetCodeByID(int id);
        /// <summary>
        /// 申请编码
        /// 根据用户编号申请编码
        /// </summary>
        /// <param name="conditions"></param>
        [OperationContract]
        void ApplicationCodeByUserID(Hashtable conditions);
        /// <summary>
        /// 修改编码
        /// 根据编码对象修改编码
        /// </summary>
        /// <param name="code"></param>
        [OperationContract]
        void ModifyCode(Hashtable code);
    }
}
