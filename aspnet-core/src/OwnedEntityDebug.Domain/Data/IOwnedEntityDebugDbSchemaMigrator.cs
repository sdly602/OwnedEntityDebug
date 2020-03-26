using System.Threading.Tasks;

namespace OwnedEntityDebug.Data
{
    public interface IOwnedEntityDebugDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
