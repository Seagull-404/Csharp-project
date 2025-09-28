using ConfigService;
using System;

namespace ConfigServices
{
    public class LayeredConfigService : IConfigService
    {
        private readonly IConfigService _primary;
        private readonly IConfigService _fallback;

        public LayeredConfigService(IConfigService primary, IConfigService fallback)
        {
            _primary = primary;
            _fallback = fallback;
        }

        public string GetValue(string key)
        {
            var value = _primary.GetValue(key);
            if (!string.IsNullOrEmpty(value))
                return value;
            return _fallback.GetValue(key);
        }
    }
}