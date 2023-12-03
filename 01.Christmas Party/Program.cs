using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Christmas_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            int food = rent * 3;
            double drinks = (int)(food - (0.2 * food));
            double decorate = (food + drinks) / 10;
            double result=food + rent + drinks + decorate;
            Console.WriteLine($"{result:f2}");
    }
    }
}
