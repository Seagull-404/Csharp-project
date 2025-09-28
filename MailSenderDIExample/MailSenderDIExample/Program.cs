using Microsoft.Extensions.DependencyInjection;
using MailServices;
using LogServices;
using ConfigService;
using ConfigServices;

namespace MailSenderDIExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ILogProvider, ConsoleLogProvider>();
            services.AddScoped<IniFileConfigService>(sp => new IniFileConfigService("mail.ini"));
            services.AddScoped<EnvVarConfigService>();
            // 优先用配置文件，配置文件没有再用环境变量
            services.AddScoped<IConfigService>(sp =>
                new LayeredConfigService(
                    sp.GetRequiredService<IniFileConfigService>(),
                    sp.GetRequiredService<EnvVarConfigService>() as IConfigService // 修复点
                )
            );
            services.AddLayeredConfig();
            services.AddScoped<IMailServices, MailService>();
            using (var sp = services.BuildServiceProvider())
            {
                var mailService = sp.GetRequiredService<IMailServices>();
                mailService.Send("Hello", "Seagull", "This is a test email.");  
            }
        }
    }
}
