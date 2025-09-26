using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = 1, Name = "jerry", Age = 28, Gender = true, Salary = 5000 });
            list.Add(new Employee { Id = 2, Name = "jim", Age = 33, Gender = true, Salary = 3000 });
            list.Add(new Employee { Id = 3, Name = "lily", Age = 35, Gender = false, Salary = 9000 });
            list.Add(new Employee { Id = 4, Name = "lucy", Age = 16, Gender = false, Salary = 2000 });
            list.Add(new Employee { Id = 5, Name = "kimi", Age = 25, Gender = true, Salary = 1000 });
            list.Add(new Employee { Id = 6, Name = "nancy", Age = 35, Gender = false, Salary = 8000 });
            list.Add(new Employee { Id = 7, Name = "zack", Age = 35, Gender = true, Salary = 8500 });
            list.Add(new Employee { Id = 8, Name = "jack", Age = 33, Gender = true, Salary = 8000 });

            //IEnumerable<Employee> items1 = list.Where(e => e.Age > 30);
            //foreach (Employee e in items1)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine(list.Count(e=>e.Salary>5000));

            //Employee e1 = list.Where(e => e.Name=="lucy").Single();
            //Employee e1 = list.Single(e => e.Name == "lucy");
            //Console.WriteLine(e1);

            //var items2 = list.OrderBy(e=>e.Age).ThenBy(e=>e.Salary);
            //var items2 = list.OrderByDescending(e => e.Salary);

            //var items2 = list.OrderByDescending(e => Guid.NewGuid());//打乱顺序.Guid随机方法

            // var items2 = list.OrderByDescending(e => e.Name[e.Name.Length-1]);//根据最后一个字母排序

            //var items =list.Skip(2).Take(2);//跳过2条取两条
            //foreach (Employee e in items)
            //{
            //    Console.WriteLine(e);
            //}


            //var items = list.GroupBy(e => e.Age);//根据年龄分组
            //foreach (var group in items)
            //{
            //    Console.WriteLine($"年龄{group.Key}的员工有：");
            //    Console.WriteLine("最大工资:"+ group.Max(e => e.Salary));
            //    foreach (Employee e in group)
            //    {
            //        Console.WriteLine(e);
            //    }
            //    Console.WriteLine();
            //}

            //var items=list.Select(e=>e.Name+","+e.Age);//投影
            //foreach (var name in items)
            //{
            //    Console.WriteLine(name);
            //}


            //var items = list.Where(e=>e.Id>2).GroupBy(e=>e.Age).OrderBy(g=>g.Key).Take(3)
            //    . Select(g=>new { Age=g.Key,Count=g.Count(),Avg=g.Average(e=>e.Salary) });
            //foreach (var item in items)
            //    {
            //    Console.WriteLine(item.Age+","+item.Count+","+item.Avg);
            //}   


            //var items = from e in list
            //            where e.Salary > 5000

            //            select new { e.Age,e.Name,Gender = e.Gender ? "男" :"女" };//SQL风格语法
            //foreach (var item in items)
            //    {
            //    Console.WriteLine(item);
            //}

            //string str = "53,33,55,888,9";
            //string[] result = str.Split(",");
            //var nums = result.Select(e => Convert.ToInt32(e));
            //Console.WriteLine(nums.Average()); 


           string  str = "hello,world,linq,lambda,expression";
            var items = str.Where(c=>char.IsLetter(c)).Select(c=>char.ToLower(c))
                .GroupBy(c=>c).Select(g=> new { Char=g.Key,Count=g.Count()}).OrderByDescending(g=>g.Count)
                .Where(g=>g.Count>2);

            foreach (var item in items)
                {
                Console.WriteLine(item);
            }

        }
    }
}
