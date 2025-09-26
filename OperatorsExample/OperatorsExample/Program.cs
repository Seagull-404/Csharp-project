
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OperatorsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.IO.File.Create("D:\\HelloWorld.txt");
            //Calculator c=new Calculator();
            //Action myAction = new Action(c.sayHello);
            //myAction();
            //int[] myIntArray=new int[] { 1,2,3,4,5};
            //Console.WriteLine(myIntArray[0]);
            //Console.WriteLine(myIntArray[myIntArray.Length-1]);
            Level level = new Level();
            Console.WriteLine(level);
            

                
        }
        enum Level { 
         low, mid,high 
        
        }
    }
    //class Calculator
    //{
    //    public void sayHello()
    //    {
    //        Console.WriteLine("hello");
    //    }
    //}
}
