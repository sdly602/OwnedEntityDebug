using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OwnedEntityDebug.Data
{
    /* This is used if database provider does't define
     * IOwnedEntityDebugDbSchemaMigrator implementation.
     */
    public class NullOwnedEntityDebugDbSchemaMigrator : IOwnedEntityDebugDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}