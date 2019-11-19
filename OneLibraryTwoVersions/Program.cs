extern alias NLog3;
extern alias NLog4;
using System;

namespace OneLibraryTwoVersions
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new NLog3::NLog.LogFactory();
            var date2 = new NLog4::NLog.LogFactory();

            Console.WriteLine(date1.GetType().Assembly.FullName);
            Console.WriteLine(date1.GetType().Assembly.CodeBase);
            Console.WriteLine();
            Console.WriteLine(date2.GetType().Assembly.FullName);
            Console.WriteLine(date2.GetType().Assembly.CodeBase);

            Console.ReadKey();
        }
    }
}
