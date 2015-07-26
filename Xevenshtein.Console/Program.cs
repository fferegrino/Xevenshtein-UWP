using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xevenshtein.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("First string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Second string:");
            string str2 = Console.ReadLine();
            int distance = Xevenshtein.Algorithm.LevenshteinDistance.Compute(str1, str2);
            Console.WriteLine("Distance: " + distance);
            Console.Read();
        }
    }
}
