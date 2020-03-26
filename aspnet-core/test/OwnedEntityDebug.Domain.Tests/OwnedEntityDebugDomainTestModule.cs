using OwnedEntityDebug.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OwnedEntityDebug
{
    [DependsOn(
        typeof(OwnedEntityDebugEntityFrameworkCoreTestModule)
        )]
    public class OwnedEntityDebugDomainTestModule : AbpModule
    {

    }
}