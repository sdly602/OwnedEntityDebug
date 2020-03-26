using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OwnedEntityDebug.Data;
using Volo.Abp.DependencyInjection;

namespace OwnedEntityDebug.EntityFrameworkCore
{
    public class EntityFrameworkCoreOwnedEntityDebugDbSchemaMigrator
        : IOwnedEntityDebugDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreOwnedEntityDebugDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the OwnedEntityDebugMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<OwnedEntityDebugMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}