using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Shop_for_Clothes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tShirtPrice=double.Parse(Console.ReadLine());
            int tShirtQuantity=int.Parse(Console.ReadLine());

            int jacketQuantity=int.Parse(Console.ReadLine());
            double jacketPrice = tShirtPrice + tShirtPrice * 0.4;

            int jeansQuantity=int.Parse(Console.ReadLine());
            double jeansPrice = jacketPrice - jacketPrice * 0.2;

            int sweaterQuantity= int.Parse(Console.ReadLine());
            double sweaterPrice = jeansPrice - 10;

            double budget = double.Parse(Console.ReadLine());

            double sum=(tShirtPrice*tShirtQuantity)+(jacketPrice*jacketQuantity)+(jeansPrice*jeansQuantity)+(sweaterPrice*sweaterQuantity);
            if (budget >= sum)
            {
                Console.WriteLine($"Yes! {budget-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No! {sum-budget:f2} leva needed.");
            }
        }
    }
}
/*
30
3
2
2
5
1000
 */