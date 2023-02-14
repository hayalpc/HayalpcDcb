using Microsoft.EntityFrameworkCore;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Library.Repository.Interfaces;

namespace Hayalpc.Dcb.Data
{
    public class HpDbContext : DbContext
    {
        public HpDbContext(DbContextOptions<HpDbContext> options) : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 
        }

        public DbSet<CarrierCollectionItem> CarrierCollectionItem { get; set; }
        public DbSet<CarrierCollection> CarrierCollection { get; set; }
        public DbSet<MerchantPayment> MerchantPayment { get; set; }

        public DbSet<Carrier> Carrier { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<BlobFile> BlobFile { get; set; }

        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<District> District { get; set; }

        public DbSet<Merchant> Merchant { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Sms> Sms { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        
        public DbSet<ResetPassword> ResetPassword { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<TableDefinition> TableDefinition { get; set; }
        public DbSet<TableHistory> TableHistory { get; set; }
        public DbSet<Tariff> Tariff { get; set; }

        public DbSet<UserBulletin> UserBulletin { get; set; }
        public DbSet<UserLog> UserLog { get; set; }

    }
}
