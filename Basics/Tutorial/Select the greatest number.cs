using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto2q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter your number, a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your number, b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + " is the greatest number");
            }
            else
            {
                Console.WriteLine(b + " is the greatest number");
            }

        }

    }
}
