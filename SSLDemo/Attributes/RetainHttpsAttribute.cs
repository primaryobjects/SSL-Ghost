using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSLDemo.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RetainHttpsAttribute : Attribute
    {
    }
}
