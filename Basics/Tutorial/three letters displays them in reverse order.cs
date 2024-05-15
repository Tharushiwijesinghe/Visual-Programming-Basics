using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoq12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char l1, l2, l3;
            Console.WriteLine("Input first letter: ");
            l1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input second letter: ");
            l2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input third letter: ");
            l3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}",l3,l2,l1);

        }
    }
}
