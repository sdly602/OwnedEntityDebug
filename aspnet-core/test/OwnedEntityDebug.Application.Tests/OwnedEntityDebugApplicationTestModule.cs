using Volo.Abp.Modularity;

namespace OwnedEntityDebug
{
    [DependsOn(
        typeof(OwnedEntityDebugApplicationModule),
        typeof(OwnedEntityDebugDomainTestModule)
        )]
    public class OwnedEntityDebugApplicationTestModule : AbpModule
    {

    }
}