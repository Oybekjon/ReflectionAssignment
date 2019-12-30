using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeDemo.TestHelpers
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestMethodAttribute : Attribute
    {
    }
}
