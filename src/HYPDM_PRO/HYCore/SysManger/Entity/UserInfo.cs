using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYCoreLib.SysManger.Interface;

namespace HYCoreLib.SysManger.Entity
{
    public class UserInfo
    {
        private string username;
        private string real_name;
        private Int64 group_id;
        private IRole role;
    }
}
