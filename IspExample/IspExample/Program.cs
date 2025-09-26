using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace IspExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sc =new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(MediumTank));
            sc.AddScoped(typeof(IVehicle), typeof(Car));
            sc.AddScoped<Driver>();
            var sp=sc.BuildServiceProvider();
            //==================================
            //ITank tank = sp.GetService<ITank>();
            //tank.Run();
            //tank.Fire();
            var driver = sp.GetService<Driver>();
            driver.Drive();
        }
    }

    class Driver
    {
        private IVehicle _vehicle;

        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();  
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    
    class Truck : IVehicle {
        public void Run() {
            Console.WriteLine("Turck is running...");
                }
    }

    interface IWeapon
    {
        void Fire();
    }


    interface ITank:IVehicle,IWeapon
    {
       
    }

    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }



        public void Run()
        {
            Console.WriteLine("Ka ka ka...");
        }
    }

    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }



        public void Run()
        {
            Console.WriteLine("Ka! ka! ka!...");
        }
    }

    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }



         public void Run()
        {
            Console.WriteLine("Ka!! ka!! ka!!...");
        }
    }
}

