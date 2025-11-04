
using System.Linq;

namespace EFCore1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                /*Person p = new Person();
                p.Name = "Test";
                ctx.Persons.Add(p);
               await ctx.SaveChangesAsync();*/
                /*var b1 = new Book
                {
                    AuthorName = "杨中科",
                    Title = "零基础趣学C语言",
                    Price = 59.8,
                    PubTime = new DateTime(2019, 3, 1)
                };
                var b2 = new Book
                {
                    AuthorName = "Robert Sedgewick",
                    Title = "算法(第4版)",
                    Price = 99,
                    PubTime = new DateTime(2012, 10, 1)
                };
                var b3 = new Book
                {
                    AuthorName = "吴军",
                    Title = "数学之美",
                    Price = 69,
                    PubTime = new DateTime(2020, 5, 1)
                };
                var b4 = new Book
                {
                    AuthorName = "杨中科",
                    Title = "程序员的SQL金典",
                    Price = 52,
                    PubTime = new DateTime(2008, 9, 1)
                };
                var b5 = new Book
                {
                    AuthorName = "吴军",
                    Title = "文明之光",
                    Price = 246,
                    PubTime = new DateTime(2017, 3, 1)
                };
                ctx.Books.Add(b1);
                ctx.Books.Add(b2);
                ctx.Books.Add(b3);
                ctx.Books.Add(b4);
                ctx.Books.Add(b5);
                await ctx.SaveChangesAsync(); */
                /*var books= ctx.Books.Where(b => b.Price > 80);
                 foreach (var book in books)
                 {
                     Console.WriteLine(book.Title);
                 }*/
                //var books =ctx.Books.OrderBy(b=>b.Price).Where(b=>b.Price<100);
                // foreach (var book in books)
                // {
                //     Console.WriteLine(book.Title+","+book.Price);
                // }
                /*var items = ctx.Books.GroupBy(b => b.AuthorName)
                     .Select(g => new { Name = g.Key, BooksCount = g.Count(),
                         MaxPrice = g.Max(b => b.Price) });
                foreach (var e in items)
                {
                    Console.WriteLine($"{e.Name},{e.BooksCount},{e.MaxPrice}");
                }*/
                var up =ctx.Books.Single(b=>b.Title=="数学之美");
                up.AuthorName = "宋浩";

                var d =ctx.Persons.Single(b=>b.Id==1);
                ctx.Persons.Remove(d);
                await ctx.SaveChangesAsync();
            }
        }
    }
}
