using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MergeTwoSortedArray
    {
        static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5] {
         5,
         15,
         25,
         30,
         47
      };
            int[] arr2 = new int[5] {
         55,
         60,
         76,
         83,
         95
      };
            int[] merged = new int[10];

            for (i = 0, j = 0; i < 5; i++)
            {
                merged[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                merged[j++] = arr2[i];
            }
            Console.WriteLine("Elements of merged array = ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Merged[" + (i) + "]:  Merged[i]");
            }
            Console.WriteLine();
        }
    }
}
