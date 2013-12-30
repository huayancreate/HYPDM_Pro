using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYCoreLib.SysManger.Interface
{
    public interface ILogin
    {
        bool Login(string username, string password);
        bool Status();
        DateTime GetLoginTime();
        string GetUsername();
        string GetPassword();
        DateTime GetLastLoginTime();
        DateTime GetLastLogoutTime();
    }
}
