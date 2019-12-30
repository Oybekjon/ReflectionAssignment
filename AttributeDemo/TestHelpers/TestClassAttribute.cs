using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeDemo.TestHelpers
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TestClassAttribute : Attribute
    {
    }
}
