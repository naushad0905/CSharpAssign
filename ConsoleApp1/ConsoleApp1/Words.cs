using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Words
    {
        public static void Main()
        {
            int a = 0, w = 1;
            string str = "My Name is Syed Naushad!";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    w++;
                }
                a++;
            }
            Console.Write($"Number of words in the string = {w}");
        }
    }
}
