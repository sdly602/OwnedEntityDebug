using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace OwnedEntityDebug.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(OwnedEntityDebugHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OwnedEntityDebugConsoleApiClientModule : AbpModule
    {
        
    }
}
