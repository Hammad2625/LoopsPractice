using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Char of the Day");
            char a = Convert.ToChar(Console.ReadLine());

            if (a == 'M' || a == 'm')
            {
                Console.WriteLine("Monday");
            }
            else if (a == 'T' || a == 't')
            {
                Console.WriteLine("Enter the second Char");
                char b = Convert.ToChar(Console.ReadLine());
                if (b == 'u')
                {
                    Console.WriteLine("Tuesday");
                }
                else if (b == 'h')
                {
                    Console.WriteLine("Thursday");
                }
                else { Console.WriteLine("N/A"); }


            }
            else if (a == 'W' || a == 'w')
            {
                Console.WriteLine("Wednesday");
            }

            else if (a == 'F' || a == 'f')
            {
                Console.WriteLine("Friday");
            }
            else if (a == 'S' || a == 's')
            {
                Console.WriteLine("Enter the Second Char");
                char c = Convert.ToChar(Console.ReadLine());
                if (c == 'a')
                {
                    Console.WriteLine("Saturday");
                }
                else if (c == 'u')
                {
                    Console.WriteLine("Sunday");
                }
                else
                {
                    Console.WriteLine("N/A");
                }

            }
        }
    }
}