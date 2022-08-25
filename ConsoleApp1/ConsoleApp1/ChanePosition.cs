using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ChanePosition
    {
        static void Main()
        {

            Console.WriteLine(test("SYED"));
            Console.ReadLine();
        }


        public static string test(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
