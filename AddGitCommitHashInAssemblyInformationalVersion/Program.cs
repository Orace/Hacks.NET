using System;
using System.Reflection;

namespace AddGitCommitHashInAssemblyInformationalVersion
{
    class Program
    {
        static void Main()
        {
            var informationalVersion = typeof(Program).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            Console.Write("Informational version is: " + informationalVersion ?? "<null>");
            Console.ReadKey();
        }
    }
}
