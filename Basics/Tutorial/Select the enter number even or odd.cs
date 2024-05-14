using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto2q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter your number:");
            int i = int.Parse(Console.ReadLine());

            if(i % 2 == 0)
            {
                Console.WriteLine(i + " is an even number.");
            }
            else
            {
                Console.WriteLine(i + " is an odd number.");
            }

        }
    }
}
