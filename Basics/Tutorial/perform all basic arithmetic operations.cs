using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoq6ii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,result;
            char option;
            Console.WriteLine(" Enter the number of a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the number of b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulus");
            Console.WriteLine("Enter the operation you want to perform : ");
            option = Convert.ToChar(Console.ReadLine());
            
            switch(option)
            {
                case '1': 
                    result = a + b;
                    Console.WriteLine(" The result of Addition is : " + result);
                    break;
                case '2':
                    result = a - b;
                    Console.WriteLine(" The result of Substraction is : " + result);
                    break;
                case '3':
                    result = a * b;
                    Console.WriteLine(" The result of Multiplication is : " + result);
                    break;
                case '4':
                    result = a / b;
                    Console.WriteLine(" The result of Division is : " + result);
                    break;
                case '5':
                    result = a % b;
                    Console.WriteLine(" The result of Modulus is : " + result);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
        }
    }
}
