using LoggingDemo1;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemServices
{
    internal class Test2
    {
        private readonly ILogger<Test2> _logger;
        public Test2(ILogger<Test2> logger)
        {
            _logger = logger;
        }
        public void Test()
        {
            _logger.LogDebug("开始执行数FTP同步");
            _logger.LogDebug("连接FTP成功");
            _logger.LogWarning("查找数据失败，重试第一次");
            // 模拟重试
            _logger.LogWarning("查找数据失败，重试第二次");
            _logger.LogError("查找数据失败，放弃");
        }
    }
}
