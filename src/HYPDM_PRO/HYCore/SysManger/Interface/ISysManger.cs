using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYCoreLib.SysManger.Entity;

namespace HYCoreLib.SysManger.Interface
{
    public interface ISysManger
    {
        ILogin Login(string username, string password);
        bool Logout(string username);
        UserInfo GetUserInfo(ILogin login);

        IUserOperate GetUserOperate(ILogin login);
    }
}
