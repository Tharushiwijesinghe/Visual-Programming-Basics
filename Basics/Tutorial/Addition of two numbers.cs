using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tuto2q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine(" Enter the number for a : ");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the number for b : ");
             b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total : " + sum(a,b));
        }

        public static int sum (int a,int b)
        {

            int total;
            total = a + b;
            return total;
        }
    }
}
