using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unsafe
            //{
            //    //Student Stu=new Student();
            //    //Stu.ID = 1;
            //    //Stu.Score = 99;
            //    //Student *pStu = &Stu;
            //    //pStu->Score = 100;
            //    //Console.WriteLine(Stu.Score);
            //}
            Student stu=new Student(null);
            Console.WriteLine(stu.Name);


        }
    }
    class Student
    { 
     
     public Student(string intName) 
        {
            if (!string.IsNullOrEmpty(intName))
            {

            }
            else
            {
                throw new ArgumentException("intName cannot be null or empty");            
            }
            this.Name=intName;        
        }
        public string Name;
    }
    //struct Student
    //{ 
    //  public int ID;
    //  public long Score;
    //}
}
