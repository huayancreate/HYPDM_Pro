using HYCoreLib.SysManger.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYCoreLib.SysManger.Interface
{
    public interface IUserOperate
    {
        bool UserCreate(UserInfo info);
        bool UsersCreate(List<UserInfo> list);

        bool UserDelete(UserInfo info);
        bool UsersDelete(List<UserInfo> list);

        bool UserUpdate(UserInfo info);
        bool UsersUpdate(List<UserInfo> list);

        UserInfo UserQueryByID(int user_id);
        List<UserInfo> UserQueryByCondition(Dictionary<string,string> condition);

        bool UserLinked(LinkInfo info);
    }
}
