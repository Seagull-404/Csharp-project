using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Vehicle
    {
        public string Owner {  get; set; }
        protected int _rpm;
        public int _fuel;
        public void Refuel()
        {
            _fuel=100;
        }
        protected void Burn( int fuel)
        {
            _fuel-=fuel;

        }
        public void Accelerate()
        {
            Burn(1);
            _rpm += 1000;

        }
        public int Speed { get { return _rpm / 100; } }
    }
    public class Car:Vehicle
    { 
       public void TurboAccelerate()
        {
            Burn(50);
            
            _rpm += 3000;

        }
    }
}
