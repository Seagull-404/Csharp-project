using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService
{
     public  interface IConfigService
    {
        public string GetValue(string key);
    }
}
