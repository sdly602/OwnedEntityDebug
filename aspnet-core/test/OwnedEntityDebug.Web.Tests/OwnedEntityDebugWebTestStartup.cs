using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace OwnedEntityDebug
{
    public class OwnedEntityDebugWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<OwnedEntityDebugWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}