using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjackeR.Pompidou;

namespace CheckArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Environment.CommandLine");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Environment.CommandLine);
            Console.WriteLine();
            Console.WriteLine("Environment.GetCommandLineArgs()");
            Console.WriteLine("--------------------------------");
            Environment.GetCommandLineArgs().ForEach((s, i) => Console.WriteLine("{0}: {1}", i, s));
            Console.WriteLine();
            Console.WriteLine("static void Main(string[] args)");
            Console.WriteLine("-------------------------------");
            args.ForEach((s, i) => Console.WriteLine("{0}: {1}", i, s));
        }
    }
}
