using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using SystemServices;


namespace LoggingDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ServiceCollection services = new ServiceCollection();
            services.AddLogging(logBuilder =>
              {
               logBuilder.AddConsole();
                  logBuilder.AddNLog();
                  logBuilder.SetMinimumLevel(LogLevel.Trace);
              });
            services.AddScoped<Test1>();
            services.AddScoped<Test2>();

            using (var sp = services.BuildServiceProvider())
            {
                var test1 =sp.GetRequiredService<Test1>();
                test1.Test();

                var test2 = sp.GetRequiredService<Test2>();
                test1.Test();

            }
        }
    }
}
