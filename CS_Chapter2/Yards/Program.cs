using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            int cost = 1050 / 9;

            Console.WriteLine("Length: " + length +  " Width: " + width + " Area: " + length * width + " Cost: " + cost  );
            Console.WriteLine("The cost of the carpet is $" + cost);
        }
    }
}
