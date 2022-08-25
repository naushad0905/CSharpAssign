using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vowels
    {
        public static void Main()
        {
            int vowel_count = 0, cons_count = 0;
            Console.Write("Enter the string :");
            string myStr = Console.ReadLine();
            int len = myStr.Length;
            for (int i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }
            Console.Write("The number of vowels in the string :" + vowel_count);

        }
    }
}
