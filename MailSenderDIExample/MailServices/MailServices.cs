using ConfigService;
using ConfigServices;
using LogServices;
using System;

namespace MailServices
{
    public class MailService : IMailServices
    {

        private readonly ILogProvider _logProvider;
        private readonly IConfigReader _configServices;


        public MailService(ILogProvider logProvider, IConfigReader configServices)
        {
            _logProvider = logProvider;
            _configServices = configServices;
        }

        public void Send(string title, string to, string body)
        {
            _logProvider.LogInfo("准备发送邮件...");
            string smtpServer = _configServices.GetValue("SmptServer");
            string username = _configServices.GetValue("UserName");
            string password = _configServices.GetValue("PassWord");
            Console.WriteLine($"邮件服务器地址{smtpServer},{username},{password}");
            Console.WriteLine($"Send email to real .....{title},{to}");
            Console.WriteLine("邮件发送完成!");
        }
    }
}
