using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);
            Console.WriteLine("================");
            Student stu2= new Student(2,"张三");
            Console.WriteLine(stu2.ID);
            Console.WriteLine(stu2.Name);
            Console.WriteLine();

        }
        class Student
        {
            public Student()
            { 
             this.ID = 1;
             this.Name = "Test";
            }
            public Student(int intID, string intName)
            { 
              this.ID= intID;
                this.Name = intName;

            }
           
            public int ID;
            public string Name;
        }
    }
}
