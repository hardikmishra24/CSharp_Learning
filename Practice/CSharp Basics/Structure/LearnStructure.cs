using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Structure
{
    internal class LearnStructure
    {
        public static void StructureDemo()
        {
            Coordinate point = new Coordinate(10, 20);
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }

    // Structures are similar to classes but they are call by value
    struct Coordinate
    {
        public int x, y;

        public Coordinate(int x, int y)
        
            {
                this.x = x;
                this.y = y;
            }


        
    }
}
