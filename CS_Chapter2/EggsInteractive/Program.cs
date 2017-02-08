using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, firstString, secondString, thirdString, fourthString;
            int first, second, third, fourth, sum;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("How many eggs did the first chicken lay {0}");
            firstString = Console.ReadLine();
            first = Convert.ToInt32(firstString);
            Console.WriteLine("How many eggs did the second chicken lay {0}");
            secondString = Console.ReadLine();
            second = Convert.ToInt32(secondString);
            Console.WriteLine("How many eggs did the third chicken lay {0}");
            thirdString = Console.ReadLine();
            third = Convert.ToInt32(thirdString);
            Console.WriteLine("How many eggs did the fourth chicken lay {0}");
            fourthString = Console.ReadLine();
            fourth = Convert.ToInt32(fourthString);
            sum = first + second + third + fourth;
            Console.WriteLine("{0} , the sum of {1} and {2} and {3} and {4} is {5}", name, first, second, third, fourth, sum);






        }
    }
}
