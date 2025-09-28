using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConfigServices
{
 public interface IConfigReader
    {
        public string GetValue(string name);
        

    }
}
