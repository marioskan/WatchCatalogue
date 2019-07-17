using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;

namespace WatchCatalogue.Infrastructure.Data
{
        // Enable-Migrations -ContextTypeName DAL.Identity.IdentityDBContext -MigrationsDirectory Migrations
        // Add-Migration -ConfigurationTypeName DAL.Identity.Migrations.Configuration Initial
        // Update-Database -ConfigurationTypeName DAL.Identity.Migrations.Configuration
        // Update-Database -ConfigurationTypeName DAL.Identity.Migrations.Configuration -TargetMigration:0
        class Context : DbContext
        {
            public Context() : base("DefaultConnection")
            {

            }

            public DbSet<SubscriptionService> SubscriptionServices { get; set; }
            public DbSet<Channel> Channels { get; set; }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<RentInfo> Rent { get; set; } 
            

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<SubscriptionService>()
                    .HasMany(ss => ss.Channels)
                    .WithRequired(ch => ch.SubscriptionService)
                    .HasForeignKey(ch => ch.SubscriptionServiceID)
                    .WillCascadeOnDelete(true);

                modelBuilder.Entity<Channel>()
                    .HasMany(ch => ch.Movies)
                    .WithRequired(m => m.Channel)
                    .HasForeignKey(m => m.ChannelID)
                    .WillCascadeOnDelete(true);

                
            }
        }
    
}
