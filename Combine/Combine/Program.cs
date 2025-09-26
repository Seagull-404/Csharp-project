using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoSomeCalc((int a, int b) => { return a * b; }, 100, 200);
           
           
        }

        static void DoSomeCalc<T>(Func<T, T, T> func, T x, T y)
        { 
         T res= func(x, y);
            Console.WriteLine(res);
        }

        
    }
}
