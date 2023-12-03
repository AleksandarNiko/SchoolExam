using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Building_materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int materialsQuant=int.Parse(Console.ReadLine());
            int tilesCount = 0;
            int toolsCount = 0;
            int paintCount = 0;
            for (int i = 0; i < materialsQuant; i++)
            {
                string typeMaterial=Console.ReadLine();
                if (typeMaterial == "tile")
                {
                    tilesCount++;
                }
                else if (typeMaterial == "tools")
                {
                    toolsCount++;
                }
               else  if (typeMaterial == "paint")
                {
                    paintCount++;
                }
            }

            Console.WriteLine($"Tiles: {tilesCount}");
            Console.WriteLine($"Tools: {toolsCount}");
            Console.WriteLine($"Paint: {paintCount}");
        }
    }
}
/*
7
tile
tools
tools
tile
paint
paint
paint
 */
