using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 44;
            int chicken2 = 39;
            int chicken3 = 27;
            int chicken4 = 12;

            Console.WriteLine("Dozen: " + (chicken1 / 12));
            Console.WriteLine("Eggs: " + (chicken1 % 12));
            Console.WriteLine("Dozen: " + (chicken2 / 12));
            Console.WriteLine("Eggs: " + (chicken2 % 12));
            Console.WriteLine("Dozen: " + (chicken3 / 12));
            Console.WriteLine("Eggs: " + (chicken3 % 12));
            Console.WriteLine("Dozen: " + (chicken4 / 12));
            Console.WriteLine("Eggs: " + (chicken4 % 12));
        }
    }
}
