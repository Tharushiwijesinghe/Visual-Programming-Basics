using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto2q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m1,m2,m3,t;
            float p;
            string name,id;
            Console.WriteLine("Enter your student id:");
            id = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the mark of subject1 : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of subject2 : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of subject3 : ");
            m3 = Convert.ToInt32(Console.ReadLine());

            t = m1 + m2 + m3;
            p = t / 3;
            Console.WriteLine("Total is : " + t);
            Console.WriteLine("Average mark is : " +  p);

            if (p <= 35)
            {
                Console.WriteLine(" Grade is F");
            }
            else if (35< p && p <= 55) 
            {
                Console.WriteLine(" Grade is C");
            }
            else if (55 < p && p <  75)
            {
                Console.WriteLine(" Grade is B");
            }
            else 
            {
                Console.WriteLine(" Grade is A");
            }

        }
    }
}
