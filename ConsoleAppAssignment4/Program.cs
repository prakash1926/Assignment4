using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int Number =int.Parse(Console.ReadLine());

            if(Number>0 )
            {
                Console.WriteLine("The number is positive.");
            }
            else if(Number<0)
            {
                Console.WriteLine("The Number is negative.");
            }
            else if(Number==0) 
            {
                Console.WriteLine("The number is zero");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
           

            if (Number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The numbe is odd");
            }
            Console.ReadKey();
        }
    }
}
