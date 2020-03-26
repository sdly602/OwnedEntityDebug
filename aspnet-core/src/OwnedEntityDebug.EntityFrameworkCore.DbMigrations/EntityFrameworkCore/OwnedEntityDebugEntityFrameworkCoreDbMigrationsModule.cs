using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace OwnedEntityDebug.EntityFrameworkCore
{
    [DependsOn(
        typeof(OwnedEntityDebugEntityFrameworkCoreModule)
        )]
    public class OwnedEntityDebugEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OwnedEntityDebugMigrationsDbContext>();
        }
    }
}
