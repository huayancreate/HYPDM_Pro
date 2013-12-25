using HYCoreLib.Architecture.Interface;
using HYCoreLib.Dev.Interface;
using HYCoreLib.ORM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYCoreLib.App.Interface
{
    public interface IAppInfo
    {
        string GetReleaseVersion();
        IDevInfo GetDevInfo();
        bool IsRelease();
        IDatabase GetDatabase();
        IArchitecture GetArchitecture();
    }
}
