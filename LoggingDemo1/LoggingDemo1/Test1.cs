using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDemo1
{
     class Test1
    {
        private readonly ILogger<Test1> _logger;
        public Test1(ILogger<Test1> logger)
        {
            _logger = logger;
        }
        public void Test()
        {
            _logger.LogDebug("开始执行数据库同步");
            _logger.LogDebug("连接数据库成功");
            _logger.LogWarning("查找数据失败，重试第一次");
            // 模拟重试
            _logger.LogWarning("查找数据失败，重试第二次");
            _logger.LogError("查找数据失败，放弃");
        }
    }
}
