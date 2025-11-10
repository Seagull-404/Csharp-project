using Microsoft.EntityFrameworkCore;

namespace EFDemo1ToX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                /*
                Article a1 = new Article();
                a1.Title = "EF关系对应测试文";
                a1.Message = "EF关系对应测试内容";

                Comment c1 = new Comment();
                c1.Message = "这是第一条评论";
                Comment c2 = new Comment();
                c2.Message = "这是第二条评论";
                a1.Comments.Add(c1);
                a1.Comments.Add(c2);

                ctx.Articles.Add(a1);
                ctx.SaveChanges();
                */
                /*
                Article a = ctx.Articles.Include(a=>a.Comments).Single(a => a.ArticleId == 1);
                Console.WriteLine(a.ArticleId);
                Console.WriteLine(a.Title);
                foreach (var comment in a.Comments)
                {
                    Console.WriteLine($"--{comment.Id}:{comment.Message}");
                }
                */
                /*
                Comment c = ctx.Comments.Include(c => c.TheArticle).Single(c => c.Id == 1);
                Console.WriteLine(c.Message);
                Console.WriteLine($"--对应的文章：{c.TheArticle.ArticleId}:{c.TheArticle.Title}");
                */
                var cmt = ctx.Comments.Single(c => c.Id == 1);
              
            }
        }
    }
}
