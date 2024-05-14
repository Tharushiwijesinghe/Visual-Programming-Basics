using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto2q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine(" Enter your number : ");
             x = int.Parse(Console.ReadLine());

            if (x % 2 == 0 ) 
            {
                Console.WriteLine(x + " is Divisible by 2");
            }
            else
            {
                Console.WriteLine(x + " is not Divisible by 2");
            }
        }
    }
}
