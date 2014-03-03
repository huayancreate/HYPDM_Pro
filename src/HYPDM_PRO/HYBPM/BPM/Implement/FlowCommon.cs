using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BP.WF;
using System.Collections;
using BP;
using BP.DA;

namespace HYBPMLib
{
    public class FlowCommon : IFlowCommon
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userNo"></param>
        public void Login(string userNo)
        {
            Dev2Interface.Port_Login(userNo);
        }
        /// <summary>
        /// 获取当前用户待办工作
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmpWorks()
        {
            return Dev2Interface.DB_GenerEmpWorksOfDataTable();
        }
        /// <summary>
        /// 获取当前用户待办工作
        /// </summary>
        /// <param name="state">流程状态</param>
        /// <param name="fk_flow">流程编号</param>
        /// <returns></returns>
        public DataTable GetEmpWorks(WFState state, string fk_flow)
        {
            return Dev2Interface.DB_GenerEmpWorksOfDataTable(state, fk_flow);
        }
        /// <summary>
        /// 获取指定用户能够发起的流程集合
        /// </summary>
        /// <param name="userNo">用户编号</param>
        /// <returns></returns>
        public DataTable GetCanStartFlow(string userNo)
        {
            return Dev2Interface.DB_GenerCanStartFlowsOfDataTable(userNo);
        }
        /// <summary>
        /// 创建并且发送流程
        /// </summary>
        /// <returns></returns>
        public void CreateAndSendWork(string flowNo, Hashtable htWork, DataSet workDtls,
            string flowStarter, string title, Int64 parentWorkID, string parentFlowNo)
        {
            Int64 work_id = Dev2Interface.Node_CreateStartNodeWork(flowNo, htWork, workDtls,
                flowStarter, title, parentWorkID, parentFlowNo);
            Dev2Interface.Node_SendWork(flowNo, work_id);
        }
        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <param name="path"></param>
        public void LoadConfig(string path)
        {
            ClassFactory.LoadConfig(path);
            SystemConfig.IsBSsystem = false;
        }

        /// <summary>
        /// 获取流程的状态
        /// </summary>
        /// <param name="fk_flow">流程编号</param>
        /// <param name="work_id">工作编号</param>
        /// <returns>流程状态</returns>
        public int WF_State(string fk_flow, long work_id)
        {
            var strSql = "select WFState from ND" + int.Parse(fk_flow) + "Rpt where OID=" + work_id + " and WFState=" + (int)BP.WF.WFState.Complete + "";
            return DBAccess.RunSQLReturnValInt(strSql);
        }
    }
}
