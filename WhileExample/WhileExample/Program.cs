using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();
                if (str1.ToLower() == "end")
                { 
                 break;
                }
                int x = 0;
                try
                {
                    x = int.Parse(str1);
                }
                catch 
                {

                    Console.WriteLine("First number isn't a number");
                    continue;
                }

                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();
                if (str2.ToLower() == "end")
                { 
                  break ;
                }
                int y = 0;
                try
                {
                    y = int.Parse(str2);
                }
                catch 
                {

                    Console.WriteLine("Second number isn't a number");
                    
                    continue;
                }

                sum = x + y;
                if (sum == 100)
                {
                    score++;
                    Console.WriteLine("Correct!{0}+{1}={2}", x, y, sum);
                }
                else
                {
                    Console.WriteLine("Error!{0}+{1}={2}", x, y, sum);
                    break;
                   
                }
            } while (true);
            Console.WriteLine("Your score is {0}",score);
            Console.WriteLine("Game Over!");
        }
    }
}
