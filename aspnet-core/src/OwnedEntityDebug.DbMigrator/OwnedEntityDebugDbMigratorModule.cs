using OwnedEntityDebug.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace OwnedEntityDebug.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(OwnedEntityDebugEntityFrameworkCoreDbMigrationsModule),
        typeof(OwnedEntityDebugApplicationContractsModule)
        )]
    public class OwnedEntityDebugDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
