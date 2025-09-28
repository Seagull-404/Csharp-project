using System;
using System.Collections.Generic;
using System.Text;

namespace LogServices
{
     public  interface  ILogProvider
    {
        public void LogError(string message);
        public void LogInfo(string message);
    }
}
