using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConvertClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.Age = 5000;
            Monkey wukong=(Monkey)stone;

            Console.WriteLine(wukong.Age);
        }
    }
    class Stone
    {
        public int Age;

        public static explicit operator Monkey(Stone stone)
        { 
         Monkey m= new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }
    }
    class Monkey
        {

        public int Age;
        
        }
}
