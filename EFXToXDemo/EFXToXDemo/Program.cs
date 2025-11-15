using Microsoft.EntityFrameworkCore;

namespace EFXToXDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (MyDBContext ctx = new MyDBContext())
            {

                /*
                Student s1 = new Student() { Name = "Alice" };
                Student s2 = new Student() { Name = "Bob" };
                Student s3 = new Student() { Name = "Charlie" };

                Teacher t1 = new Teacher() { Name = "Mr. Smith" };
                Teacher t2 = new Teacher() { Name = "Ms. Johnson" };
                Teacher t3 = new Teacher() { Name = "Dr. Brown" };

                s1.Teachers.Add(t1);
                s1.Teachers.Add(t2);

                s2.Teachers.Add(t2);
                s2.Teachers.Add(t3);

                s3.Teachers.Add(t1);
                s3.Teachers.Add(t3);
                s3.Teachers.Add(t2);

                ctx.Students.AddRange(s1, s2, s3);
                ctx.Teachers.AddRange(t1, t2, t3);
                ctx.SaveChanges();
                */
                var teachers = ctx.Teachers.Include(t => t.Students);
                foreach (var t in teachers)
                {
                    Console.WriteLine(t.Name);
                    foreach (var s in t.Students)
                    {
                        Console.WriteLine($"\t{s.Name}");

                    }
                }
            }
        }
    }
}
