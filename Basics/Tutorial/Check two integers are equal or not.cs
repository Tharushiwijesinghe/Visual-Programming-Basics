using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoq13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Check two integers are equal or not");
            Console.WriteLine("Enter your first integer: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second integer: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1 != n2)
            {
                Console.WriteLine(n1 + " and " + n2 + " are not equal integers");
            }
            else
            {
                Console.WriteLine(n1 + " and " + n2 + " are equal integers");
            }


        }
    }
}
