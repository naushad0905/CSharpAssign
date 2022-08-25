using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Multiplication
    {
        public static void Main()
        {
            int num1, num2, num3, result;

            Console.Write("Enter the num1 to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the num2 to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the num3 to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            result = num1 * num2 * num3;
            Console.WriteLine($"Output: {num1} x {num2} x {num3} = {result}");
        }
    }
}
