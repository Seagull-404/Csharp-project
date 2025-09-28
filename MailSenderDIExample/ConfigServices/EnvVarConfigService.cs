using System;

namespace ConfigService
{
    public interface IConfigReader
    {
        string GetValue(string key);
    }

    public class EnvVarConfigService : IConfigReader
    {
        public string GetValue(string key)
        {
            return Environment.GetEnvironmentVariable(key) ?? string.Empty;
        }
    }
}
