using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto2q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;
            Console.WriteLine(" Enter the grade using Using initial Uppercase : ");
            grade = Convert.ToChar(Console.ReadLine());

            switch (grade) 
            {
                case 'A':
                    Console.WriteLine("VERY GOOD");
                    break;
                case 'B':
                    Console.WriteLine("FAIR");
                    break;
                case 'Y':
                    Console.WriteLine("ABSENT");
                    break;
                case 'F':
                    Console.WriteLine("FAIL");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
    }
}
