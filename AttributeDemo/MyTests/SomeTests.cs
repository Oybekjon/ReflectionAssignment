using AttributeDemo.TestHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeDemo.MyTests
{
    [TestClass]
    public class SomeTests
    {
        [TestMethod]
        public void TestMethod()
        {
            Console.WriteLine("Alex is a cool guy");
        }
        
        [TestMethod]
        public void SecondTestMethod()
        {
            Console.WriteLine("Oybek is a cool guy");
        }

        public void NotATest()
        {
            Console.WriteLine("Do not run this");
        }
    }
}
