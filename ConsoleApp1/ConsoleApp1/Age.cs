using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Age
    {
        public static void Main()
        {
            Console.Write("Input your current Age:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your age after 10 years:");
            Age = Age + 10;
            Console.Write("{0} ", Age);
        }
    }
}
