using ConfigService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    public class LayeredConfigRead : IConfigReader
    {
        private readonly IEnumerable<IConfigService> _services;
        public LayeredConfigRead(IEnumerable<IConfigService> services)
        {
            _services = services;
        }

        public string GetValue(string name)
        {
            string value = null;

            foreach (var service in _services)
            {
                var newValue = service.GetValue(name);
                if (newValue != null)
                    value = newValue;
            }
            return value;
        }
    }
}
