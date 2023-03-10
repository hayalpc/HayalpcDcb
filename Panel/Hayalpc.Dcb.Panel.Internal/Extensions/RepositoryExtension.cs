using Microsoft.Extensions.DependencyInjection;
using Hayalpc.Dcb.Data;
using Hayalpc.Dcb.Data.Models;

namespace Hayalpc.Dcb.Panel.Internal.Extensions
{
    public static class RepositoryExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Category>, Repository<Category>>();
            services.AddScoped<IRepository<Country>, Repository<Country>>();
            services.AddScoped<IRepository<City>, Repository<City>>();
            services.AddScoped<IRepository<District>, Repository<District>>();
            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IRepository<Role>, Repository<Role>>();
            services.AddScoped<IRepository<UserRole>, Repository<UserRole>>();
            services.AddScoped<IRepository<RolePermission>, Repository<RolePermission>>();
            services.AddScoped<IRepository<ResetPassword>, Repository<ResetPassword>>();
            services.AddScoped<IRepository<Merchant>, Repository<Merchant>>();
            services.AddScoped<IRepository<Service>, Repository<Service>>();
            services.AddScoped<IRepository<Transaction>, Repository<Transaction>>();
            services.AddScoped<IRepository<Subscription>, Repository<Subscription>>();
            services.AddScoped<IRepository<TableDefinition>, Repository<TableDefinition>>();
            services.AddScoped<IRepository<TableHistory>, Repository<TableHistory>>();
            services.AddScoped<IRepository<UserBulletin>, Repository<UserBulletin>>();
            services.AddScoped<IRepository<UserLog>, Repository<UserLog>>();
            services.AddScoped<IRepository<Sms>, Repository<Sms>>();
            services.AddScoped<IRepository<BlobFile>, Repository<BlobFile>>();
            services.AddScoped<IRepository<Tariff>, Repository<Tariff>>();
            services.AddScoped<IRepository<CarrierCollection>, Repository<CarrierCollection>>();
            services.AddScoped<IRepository<CarrierCollectionItem>, Repository<CarrierCollectionItem>>();
            services.AddScoped<IRepository<MerchantPayment>, Repository<MerchantPayment>>();
        }
    }
}
