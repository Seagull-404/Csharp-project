using IocDemo1;
using Microsoft.Extensions.DependencyInjection;

namespace IocDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<ITestService, TestServiceImpl>();
            services.AddTransient<ITestService, TestServiceImpl2>();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var t = sp.GetServices<ITestService>();

                // 取第一个示例
                ITestService first = t.First();
                first.Name = "Seagull";
                first.SayHi();

                var second = t.Skip(1).First();
                second.Name = "海鸥";
                second.SayHi();

                // 如果你想遍历所有示例
                foreach (ITestService T in t)
                {
                    Console.WriteLine(T.GetType());
                }
            }
        }            
    }

    public interface ITestService
    {
        public string Name { get; set; }
        public void SayHi();
    }

    public class TestServiceImpl : ITestService
    {
        public string Name { get; set; }
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}");
        }
    }

    public class TestServiceImpl2 : ITestService
    {
        public string Name { get; set; }
        public void SayHi()
        {
            Console.WriteLine($"你好，我是{Name}");
        }
    }
}
