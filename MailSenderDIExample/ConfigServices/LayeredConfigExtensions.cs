using System;
using System.Collections.Generic;
using System.Text;
using ConfigService;
namespace Microsoft.Extensions.DependencyInjection
{
   public static class LayeredConfigExtensions
    {
        public static void  AddLayeredConfig(this IServiceCollection services)
        {
            services.AddSingleton<ConfigServices.IConfigReader, ConfigServices.LayeredConfigRead>();
            
        }

    }
}
