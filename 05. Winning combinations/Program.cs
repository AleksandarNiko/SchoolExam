using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Winning_combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int winNums = 0;

            for (int i = 10000; i < 99999; i++)
            {
                int ed = i % 10;
                int des = (i % 100) / 10;
                int stot = (i % 1000) / 100;
                int hil = (i % 10000) / 1000;
                int desehil = (i % 100000) / 10000;

                bool isZero = ed == 0 || des == 0 || stot == 0 || hil == 0 || desehil == 0;

                if (desehil + hil + stot == n && des % 2 == 0 && ed == 1 && !isZero)
                {
                    Console.Write(i + " ");
                    winNums++;
                }
            }
            Console.Write($"Count of winner numbers: {winNums}");
        }
    }
}
