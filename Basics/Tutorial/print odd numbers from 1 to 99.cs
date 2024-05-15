using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto2q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers between 0 to 100: ");
            for( int i = 0; i < 100; i++)
            {
                if( i%2 == 1 )
                {
                    Console.WriteLine("\t" + i); 
                }

            }
        }
    }
}
