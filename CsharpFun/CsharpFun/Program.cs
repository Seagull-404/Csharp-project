using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c=new Calculator();
            Console.WriteLine(c.GetConeVolume(6,10));
        }
    }
    class Calculator
    {
        public double GetCircleArea(double r)
        {
                return Math.PI * r * r;
        }


        public double GetCylinerVolume(double r, double h)
        {
            return GetCircleArea(r) * h;
        }
        public double GetConeVolume(double r, double h)
        {
            return GetCylinerVolume(r,h)* h / 3;
        }
    }
}
