using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoq9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1,s2;
            Console.WriteLine("Enter your first word:");
            s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your second word:");
            s2 = Convert.ToString(Console.ReadLine());
            string s3 = string.Concat( s1 , s2);
            Console.WriteLine(s3);

        }
    }
}
