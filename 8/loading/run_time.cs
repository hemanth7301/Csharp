using System;
using System.Reflection;

namespace loading
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllfile = @"/Users/sakhamurisaihemanth/Desktop/dynamic_loading.dll";
            var assembly = Assembly.LoadFile(dllfile);
            var type = assembly.GetType("dynamic_loading.hello_world");
            var obj = Activator.CreateInstance(type);

            Console.WriteLine("Available methods");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Select a method name");
            var method1 = type.GetMethod(Console.ReadLine());
            string[] name = new string[1];
            Console.WriteLine("Enter a name");
            name[0]=Console.ReadLine();
            var result = method1.Invoke(obj, name);
            Console.WriteLine(result);

            //var method2 = type.GetMethod("SayBye");
            //string result2 = (string)(method2.Invoke(obj, name));
            //Console.WriteLine(result2);
        }
    }
}
