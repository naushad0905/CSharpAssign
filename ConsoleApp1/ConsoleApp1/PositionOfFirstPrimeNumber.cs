using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PositionOfFirstPrimeNumber
    {
        static readonly int limit = 1000000;
        static int[] position = new int[limit + 1];
        static void sieve()
        {
            position[0] = -1;
            position[1] = -1;

            int pos = 0;
            for (int i = 2; i <= limit; i++)
            {
                if (position[i] == 0)
                {

                    position[i] = ++pos;
                    for (int j = i * 2; j <= limit; j += i)
                        position[j] = -1;
                }
            }
        }

        public static void Main(String[] args)
        {
            sieve();

            int n = 11;
            Console.Write(position[n]);
        }
    }
}
