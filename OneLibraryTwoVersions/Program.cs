extern alias NLog3;
extern alias NLog4;
using System;

namespace OneLibraryTwoVersions
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = new NLog3::NLog.LogFactory();
            var factory2 = new NLog4::NLog.LogFactory();

            Console.WriteLine(factory1.GetType().Assembly.FullName);
            Console.WriteLine(factory1.GetType().Assembly.CodeBase);
            Console.WriteLine();
            Console.WriteLine(factory2.GetType().Assembly.FullName);
            Console.WriteLine(factory2.GetType().Assembly.CodeBase);

            Console.ReadKey();
        }
    }
}
