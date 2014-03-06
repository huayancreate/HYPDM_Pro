using PDM_Services_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using PDM_Entity.DocManage;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading; 

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class DocSecurityLevelBuild : IDocSecurityLevelBuild
    {
        #region  文档密级

        /// <summary>
        /// 查询所有的文档密级
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        public List<dense> getAllDense()
        {
            List<dense> denseList = new List<dense>();
            dense d1 = new dense();
            d1.id = 1;
            d1.name = "绝密";
            dense d2 = new dense();
            d2.id = 2;
            d2.name = "机密";
            dense d3 = new dense();
            d3.id = 3;
            d3.name = "秘密";
            dense d4 = new dense();
            d4.id = 4;
            d4.name = "一般";
            denseList.Add(d1);
            denseList.Add(d2);
            denseList.Add(d3);
            denseList.Add(d4);
            return denseList;
        }

        /// <summary>
        /// 查询所有的文档密级关系
        /// </summary>
        /// <param name="doc_grant"></param>
        /// <returns></returns>
        public List<dense_role> getAllDenseRole()
        {
            List<dense_role> denseRoleList = new List<dense_role>();
            dense_role den1 = new dense_role();
            den1.dense_id = 1;
            den1.role_id = 1;
            den1.role_name = "系统管理员角色";

            dense_role den2 = new dense_role();
            den2.dense_id = 1;
            den2.role_id = 2;
            den2.role_name = "工艺系统";

            dense_role den3 = new dense_role();
            den3.dense_id = 2;
            den3.role_id = 3;
            den3.role_name = "系统集成";

            dense_role den4 = new dense_role();
            den4.dense_id = 2;
            den4.role_id = 4;
            den4.role_name = "文档管理";

            dense_role den5 = new dense_role();
            den5.dense_id = 3;
            den5.role_id = 5;
            den5.role_name = "系统管理员角色";

            dense_role den6 = new dense_role();
            den6.dense_id = 4;
            den6.role_id = 1;
            den6.role_name = "系统管理员角色";

            dense_role den7 = new dense_role();
            den7.dense_id = 4;
            den7.role_id = 7;
            den7.role_name = "变更管理";

            dense_role den8 = new dense_role();
            den8.dense_id = 4;
            den8.role_id = 8;
            den8.role_name = "项目管理";

            denseRoleList.Add(den1);
            denseRoleList.Add(den2);
            denseRoleList.Add(den3);
            denseRoleList.Add(den4);
            denseRoleList.Add(den5);
            denseRoleList.Add(den6);
            denseRoleList.Add(den7);
            denseRoleList.Add(den8);
            return denseRoleList;
        }

        #endregion 
    }
}
