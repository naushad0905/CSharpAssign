﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FindPrimeNumber
    {
        public static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static void Main()
        {
            Console.Write("\n\nFunction : To check a number is prime or not :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (chkprime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
}
