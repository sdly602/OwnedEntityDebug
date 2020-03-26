using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace OwnedEntityDebug.EntityFrameworkCore
{
    public static class OwnedEntityDebugDbContextModelCreatingExtensions
    {
        public static void ConfigureOwnedEntityDebug(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Order>(b =>
            {
                b.ToTable(OwnedEntityDebugConsts.DbTablePrefix + "Orders", OwnedEntityDebugConsts.DbSchema);
                b.ConfigureFullAuditedAggregateRoot();

                b.HasMany(x => x.Cargoes).WithOne().HasForeignKey(x => x.OrderId);
                b.OwnsOne(x => x.InvoiceAddress);

            });

            builder.Entity<Cargo>(b =>
            {
                b.ToTable(OwnedEntityDebugConsts.DbTablePrefix + "Cargoes", OwnedEntityDebugConsts.DbSchema);
                b.ConfigureFullAuditedAggregateRoot();

                b.HasOne<Order>().WithMany().HasForeignKey(x => x.OrderId);
                b.OwnsOne(x => x.ConsigeeAddress);

            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}