using HYCoreLib.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYCoreLib.ORM.Interface
{
    public interface IDatabase
    {
        DatabaseInfo GetInfo();
    }
}
