using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student.Amount = -100;
                Console.WriteLine(Student.Amount);
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        class Student
        {
            private int age;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0 && value <= 100)
                    {
                        age = value;
                    }
                    else
                    {
                        throw new Exception("Age value has error");
                    }
                }

            }
            private static int amount;

            public static int Amount
            {
                get { return amount; }
                set
                {
                    if (value >= 0)
                    {
                        Student.amount = value;
                    }
                    else
                    {
                        throw new Exception("Value has error");
                    }

                }
            }



        }
    }
}
