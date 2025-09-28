using Microsoft.Extensions.DependencyInjection;

namespace DIDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<Controller>();
            services.AddScoped<ICloudStorage, CloudStorageImpl>();
            services.AddScoped<Ilog, LogImpl>();
            services.AddScoped<IConfig, ConfigImpl>();
            using (var sp =services.BuildServiceProvider())
            {
                var c = sp.GetRequiredService<Controller>();
                string data = Console.ReadLine();
                string name = Console.ReadLine();

                c.SaveData(data,name);
            }

        }
    }

    class Controller
    {
        private readonly ICloudStorage _cloudStorage;
        private readonly Ilog _log;
        
        public Controller(ICloudStorage cloudStorage, Ilog log)
        {
            _cloudStorage = cloudStorage;
            _log = log;
        }

        public void SaveData(string data, string name)
        {
            _log.Log($"准备保存数据，name={name},data={data}");
            _cloudStorage.Save(data, name);
            _log.Log($"保存数据完成，name={name},data={data}");
        }
    }

    interface Ilog

    {
        public void Log(string message);
    }

    public class LogImpl : Ilog
    {
        public void Log(string message)
        {
            Console.WriteLine($"日志：{message}");
        }
    }

    interface IConfig
    {
        public string GetValue(string name);
    }
    public class ConfigImpl : IConfig
    {
        public string GetValue(string name)
        {
            return $"配置项：{name}";
        }
    }

    interface ICloudStorage
    {
        public void Save(string data,string name);
    }
    class CloudStorageImpl : ICloudStorage
    {
        private readonly Ilog _log;
        private readonly IConfig _config;
        public CloudStorageImpl(Ilog log, IConfig config)
        {
            _log = log;
            _config = config;
        }
        public void Save(string data, string name)
        {
            var endpoint = _config.GetValue("endpoint");
            var bucket = _config.GetValue("bucket");
            _log.Log($"保存数据到云存储，endpoint={endpoint},bucket={bucket},name={name},data={data}");
        }
    }
}