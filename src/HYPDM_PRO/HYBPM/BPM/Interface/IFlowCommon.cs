using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BP.WF;
using BP.DA;
using BP.Sys;
using System.Data;
using System.Collections;

namespace HYBPMLib
{
    public interface IFlowCommon
    {

        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <param name="path"></param>
        void LoadConfig(string path);
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userNo"></param>
        void Login(string userNo);
        /// <summary>
        /// 获取当前用户待办工作
        /// </summary>
        /// <returns></returns>
        DataTable GetEmpWorks();
        /// <summary>
        /// 获取当前用户待办工作
        /// </summary>
        /// <param name="state">流程状态</param>
        /// <param name="fk_flow">流程编号</param>
        /// <returns></returns>
        DataTable GetEmpWorks(WFState state, string fk_flow);
        /// <summary>
        /// 获取指定用户能够发起的流程集合
        /// </summary>
        /// <param name="userNo">用户编号</param>
        /// <returns></returns>
        DataTable GetCanStartFlow(string userNo);
        /// <summary>
        /// 创建并且发送流程
        /// </summary>
        /// <returns></returns>
        void CreateAndSendWork(string flowNo, Hashtable htWork, DataSet workDtls,
            string flowStarter, string title, Int64 parentWorkID, string parentFlowNo);

        /// <summary>
        /// 获取流程的状态
        /// </summary>
        /// <param name="fk_flow">流程编号</param>
        /// <param name="work_id">工作编号</param>
        /// <returns>流程状态</returns>
        int WF_State(string fk_flow, Int64 work_id);

    }
}
