using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Collections;
using PDM_Entity.ChangeManagement;
using PDM_Entity.MyTaskBox;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IChangeManagementService
    {
        /// <summary>
        /// 保存变更申请
        /// </summary>
        /// <param name="attr"></param>
        [OperationContract]
        void CreateChangeApplication(Hashtable attr);
        /// <summary>
        /// 查询变更申请书
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [OperationContract]
        List<ChangeApplicatioin> GetChangeApplicatioinByCondition(Hashtable condition);
        /// <summary>
        /// 获取变更文档列表
        /// 根据变更申请书编号获取变更文档列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<Document> GetChangeDocumentsByChangeApplicationID(int id);
        /// <summary>
        /// 获取变更结构列表
        /// 据变更申请书编号获取变更结构列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<ChangeStructure> GetChangeStructureByChangeApplicationID(int id);
        /// <summary>
        /// 获取变更发放通知组
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [OperationContract]
        List<Group> GetGroupsByUserID(int userid);
        /// <summary>
        /// 获取变更发放通知人员
        /// </summary>
        /// <param name="groupid"></param>
        /// <returns></returns>
        [OperationContract]
        List<User> GetUsersByGroupID(int groupid);
        /// <summary>
        /// 添加变更通知组
        /// 根据用户添加变更通知组
        /// </summary>
        /// <param name="hashtable"></param>
        [OperationContract]
        void AddGroupWithUserID(Hashtable hashtable);
        /// <summary>
        /// 修改变更通知组
        /// 根据用户修改变更通知组
        /// </summary>
        /// <param name="hashtable"></param>
        [OperationContract]
        void ModifyGroupByID(Hashtable hashtable);
        /// <summary>
        /// 删除变更通知组
        /// 根据变更通知组编号删除变更通知组
        /// </summary>
        /// <param name="id"></param>
        [OperationContract]
        void DeleteGroupByID(int id);
        /// <summary>
        /// 获取所有文档列表
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Document> getAllDocuments();
    }
}
