using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NewExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Form myForm = new Form() { Text = "hello",FormBorderStyle=FormBorderStyle.SizableToolWindow};
            //myForm.ShowDialog();
            //var person = new { Name='x',Age=24};
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);
            //CsStudent CsStu =new CsStudent();
            //CsStu.Report();
            uint x=uint.MaxValue;
            Console.WriteLine(x);
            string binStr=Convert.ToString(x,2);
            Console.WriteLine(binStr);

            checked
            {
                try
                {
                    uint y = (x + 1);
                    Console.WriteLine(y);
                }
                catch (OverflowException)
                {

                    Console.WriteLine("Tere's overflow!");
                }

            }

        }
    }
    //class Student
    //{
    //    public void Report()
    //    {
    //        Console.WriteLine("i'm a student");
    //    }
    //}
    //    class CsStudent : Student
    //    { }
    
}
