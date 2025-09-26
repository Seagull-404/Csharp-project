using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1=new Student(01,"Wuhaitao");
            Student stu2 = new Student(02, "Qiaoyifan");
            Console.WriteLine(Student.Amount);
            
        }
    }
    class Student
        {
         public static int Amount { get; set; }
        static Student()
            {

            Amount = 100;
        }
        public Student(int id,string name) 
        {
            this.ID = id;      
            this.Name = name;
            Amount++;
        }

        ~Student()
        {
            Amount--;
        }

        public int ID { get; set; } 
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I'm #{this.ID} student,my name is {this.Name}.");
        }
        }
}
