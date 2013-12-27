using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYCoreLib.ORM.Entity;

namespace HYCoreLib.ORM.Interface
{
    public interface IDatabaseOperator
    {
        List<Element> GetElementsById(string id);
        Element GetElementById(string id);

    }
}
