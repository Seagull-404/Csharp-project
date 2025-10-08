using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config1
{
    class TestController
    {
        public readonly IOptionsSnapshot<Config> _optconfig;
        public TestController(IOptionsSnapshot<Config> optconfig)
        {
            _optconfig = optconfig;
        }

        public void Print()
        {
            Console.WriteLine(_optconfig.Value.Name);
            Console.WriteLine("*********************");
            Console.WriteLine(_optconfig.Value.Age);
            Console.WriteLine("*********************");
            Console.WriteLine(_optconfig.Value.Proxy.Address);
            Console.WriteLine("*********************");
            Console.WriteLine(_optconfig.Value.Proxy.Port);

        }
    }
}
