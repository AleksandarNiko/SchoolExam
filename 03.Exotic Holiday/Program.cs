using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exotic_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nights=int.Parse(Console.ReadLine());
            string destination=Console.ReadLine();
            string typeRoom=Console.ReadLine();
            double nightPrice = 0;
            switch (destination)
            {
                case "Maldives":
                    if (typeRoom == "beach villa")
                    {
                        nightPrice = 380;
                    }
                    else if (typeRoom == "apartment")
                    {
                        nightPrice = 450;
                    }
                    break;

                case "Bora Bora":
                    if (typeRoom == "beach villa")
                    {
                        nightPrice = 350;
                    }
                    else if (typeRoom == "apartment")
                    {
                        nightPrice = 420;
                    }
                    break;
                case "Singapore":
                    if (typeRoom == "beach villa")
                    {
                        nightPrice = 390;
                    }
                    else if (typeRoom == "apartment")
                    {
                        nightPrice = 490;
                    }
                    break;
            }

            Console.WriteLine($"They have to spend {nights*nightPrice:f2} leva.");
        }
    }
}
