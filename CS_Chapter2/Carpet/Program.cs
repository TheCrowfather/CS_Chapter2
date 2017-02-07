using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 27;
            int width = 13;
            int area = 351;
            

            Console.WriteLine("Length: " + length + " Width: " + width + " Area: " + length * width );
            Console.WriteLine("The room is 351 square feet");


            Console.WriteLine("Cost: " + area / 2.50);
            Console.WriteLine("The cost is $" + area / 2.50);
        }
    }
}
