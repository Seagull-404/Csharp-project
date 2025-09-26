using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace HelloOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Refuel();
            car.TurboAccelerate();
            Console.WriteLine(car._fuel);
            Console.WriteLine(car.Speed);

        }
    }
}