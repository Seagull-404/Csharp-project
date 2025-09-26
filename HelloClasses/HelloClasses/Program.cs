using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace HelloClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        Calculator calc=new Calculator();
            double res = calc.Add(4,6);
            Console.WriteLine(res);
        


        } 
    }
}
