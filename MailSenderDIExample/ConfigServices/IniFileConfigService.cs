using ConfigService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConfigServices
{
    public class IniFileConfigService : IConfigService
    {
        private readonly string iniFilePath;

        public IniFileConfigService(string iniFilePath = "mail.ini")
        {
            this.iniFilePath = iniFilePath;
        }

        public string GetValue(string key)
        {
            if (!File.Exists(iniFilePath))
                throw new FileNotFoundException($"配置文件未找到: {iniFilePath}");

            foreach (var line in File.ReadAllLines(iniFilePath, Encoding.UTF8))
            {
                var trimmed = line.Trim();
                if (trimmed.StartsWith("#") || string.IsNullOrWhiteSpace(trimmed))
                    continue;

                var parts = trimmed.Split('=', 2);
                if (parts.Length == 2 && parts[0].Trim() == key)
                    return parts[1].Trim();
            }
            return null;
        }
    }
}
