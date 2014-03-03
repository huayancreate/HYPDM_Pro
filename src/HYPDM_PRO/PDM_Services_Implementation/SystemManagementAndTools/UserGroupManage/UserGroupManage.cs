using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.SystemManagementAndTools;
using PDM_Services_Interface;
using System.ComponentModel;



namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "PDM_Services_Implementation")]
    public class UserGroupManage : IUserGroupManage
    {
        public IList<Group> findGroup(String condition)
        {
            IList<Group> list = new BindingList<Group>();
            Group g = new Group();
            g.Name = "调研组";
            g.Id = 1;
            g.Create_user_id = 12345;
            g.Create_date = new DateTime();
            g.Modify_user_id = 1234566;
            g.Modify_date = new DateTime();
            g.Remark = "我们是负责市场调研的，我们很有价值";

            Group g1 = new Group();
            g1.Name = "研发组";
            g1.Id = 2;
            g1.Create_user_id = 12345;
            g1.Create_date = new DateTime();
            g1.Modify_user_id = 1234566;
            g1.Modify_date = new DateTime();
            g1.Remark = "我们是负责项目研发的，我们很有价值";

            Group g2 = new Group();
            g2.Name = "酱油组";
            g2.Id = 3;
            g2.Create_user_id = 12345;
            g2.Create_date = new DateTime();
            g2.Modify_user_id = 1234566;
            g2.Modify_date = new DateTime();
            g2.Remark = "我们天天干事，干的都是乱七八糟的事，在老总眼里我们没有利用价值。关键的是赚的钱都不够吃的，我们学不到东西，我们是最卑微的码农";
            list.Add(g);
            list.Add(g1);
            list.Add(g2);
            return list;

        }
        public bool AddGroup(Group group)
        {
            return false;
        }
        public bool DeleteGroup(int groupID)
        {
            return false;
        }
    }
}
