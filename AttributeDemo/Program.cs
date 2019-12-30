using AttributeDemo.TestHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AttributeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Assembly.GetExecutingAssembly().GetTypes();
            var allClasses = result.Where(x => !x.IsAbstract && x.IsClass).ToList();
            var relevant = new List<Type>();
            foreach (var item in allClasses)
            {
                var testAttr = item.GetCustomAttribute<TestClassAttribute>();
                if (testAttr != null)
                {
                    // Class has this attribute. We need it
                    relevant.Add(item);
                }
            }

            foreach (var classDefinition in relevant)
            {
                var allMethods = classDefinition.GetMethods(BindingFlags.Public | BindingFlags.Instance).ToList();
                var relevantMethod = new List<MethodInfo>();
                foreach (var method in allMethods)
                {
                    var attr = method.GetCustomAttribute<TestMethodAttribute>();
                    if (attr != null)
                    {
                        // our guy
                        relevantMethod.Add(method);
                    }
                }

                var instance = Activator.CreateInstance(classDefinition);

                foreach (var relMeth in relevantMethod)
                {
                    relMeth.Invoke(instance, new object[] { });
                }
            }

            Console.ReadLine();
        }
    }
}
