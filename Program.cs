using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Starting number");
            int start = Int32.Parse(Console.ReadLine()); //ReadLine and parse To Int
            Console.WriteLine("Insert Ending number");
            int end = Int32.Parse(Console.ReadLine()); //ReadLine and parse To Int
            int n = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");   //indicate which number
                if ((i % 3) == 0)    //If Divisible by 3 print Fizz
                {
                    Console.Write("Fizz");
                }
                if ((i % 5) == 0)   //If Divisible by 5 Print Buzz
                {
                    Console.Write("Buzz");
                }
                Console.Write("\n");//always print next line
            }
            Console.WriteLine("Complete");
            Console.ReadKey();
        }
    }
}
