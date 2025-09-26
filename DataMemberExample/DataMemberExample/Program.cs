using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMemberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student();
            //stu1.Age = 40;
            //stu1.Score = 90;

            //Student stu2 = new Student();
            //stu2.Age = 23;
            //stu2.Score = 70;
            List<Student>stuList=new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;
                stuList.Add(stu);
            }

            int TotalAge = 0;
            int TotalScore = 0;
            foreach (var stu in stuList)
            {
                TotalAge += stu.Age;
                TotalScore += stu.Score;
            }

            Student.AverageAge= TotalAge/Student.Amount;
            Student.AverageScore = TotalScore/Student.Amount;

            Student.ReportAmount();
            Student.ReportAverageAge();
            Student.ReportAverageScore();

        }
    }
    class Student 
    {
       public int Age;
       public int Score;

        public static int AverageAge;
        public static int AverageScore;
        public static int Amount;

        public Student()
        {
            Student.Amount++;
        }
        public static void ReportAmount()
        {
            Console.WriteLine(Student.Amount);
        }
        public static void ReportAverageAge()
        {
            Console.WriteLine(Student.AverageAge);
        }
        public static void ReportAverageScore()
        {
            Console.WriteLine(Student.AverageScore);
        }

    }


}
