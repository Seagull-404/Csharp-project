using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options; // 添加此行  
namespace Config1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<TestController>();

            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            //configurationBuilder.AddJsonFile("config.json", optional: true, reloadOnChange: true);
            //configurationBuilder.AddCommandLine(args);
            configurationBuilder.AddEnvironmentVariables();
            IConfigurationRoot configRoot = configurationBuilder.Build();

            services.AddOptions().Configure<Config>(e => configRoot.Bind(e));
            /*string name = configRoot["name"];
            Console.writeline($"name from config.json: {name}");
            string add = configroot.getsection("proxy:address").value;
            Console.writeline($"proxy address from config.json: {add}");*/
            //Proxy proxy = configRoot.GetSection("proxy").Get<Proxy>();

            /* Config config = configRoot.Get<Config>();
             //Console.WriteLine($"proxy address AND port from config.json: {proxy.Address},{proxy.Port}");
             Console.WriteLine(config.Name);
             Console.WriteLine(config.Age);
             Console.WriteLine(config.Proxy.Address);
             Console.WriteLine(config.Proxy.Port);
             Console.ReadKey();*/
            using (var provider = services.BuildServiceProvider()) // 需要 Microsoft.Extensions.DependencyInjection
            {
                var c = provider.GetRequiredService<TestController>();
                c.Print();
            }

        }
    }

    class Config     {
        public string Name { get; set; }
        public int Age { get; set; }
        public Proxy Proxy { get; set; }
    }
    class Proxy
    { 
        
        public string Address { get; set; }
              public int Port { get; set; }

    }
}
