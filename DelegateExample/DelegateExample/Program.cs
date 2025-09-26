using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate double Calc(double x, double y);

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Calc calc1 = new Calc(calculator.Add);

            double a = 100;
            double b = 200;
            double c = 0;
            c = calc1.Invoke(a, b);
            Console.WriteLine(c);
        }
    }
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
