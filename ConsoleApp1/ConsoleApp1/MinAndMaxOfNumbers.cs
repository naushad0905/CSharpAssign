using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MinAndMaxOfNumbers
    {
        static void Main()
        {
            int[] Arr = { 50, 20, -40, -30, 0, -15, 10, 30, -90 };
            Console.WriteLine($"Maximum Element : {Arr.Max()}");
            Console.WriteLine($"Minimum Element : { Arr.Min()}");
            Console.Read();
        }
    }
}
