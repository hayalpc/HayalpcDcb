using Microsoft.Extensions.DependencyInjection;
using Hayalpc.Dcb.Panel.External.Services;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hayalpc.Dcb.Panel.External.Extensions
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {

            //var serviceList = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetCustomAttributes(typeof(ServiceTypeAttrAttribute)).Any() && t.IsClass && !t.IsInterface)
            //    .Select(x => new { Type = x.GetElementType(), x.Name, Interface = x.GetInterfaces().Where(k => k.GetCustomAttributes(typeof(ServiceTypeAttrAttribute)).Any()).FirstOrDefault() }).ToList();
            //foreach(var serviceType in serviceList)
            //{
            //    //services.AddScoped(serviceType.Interface.GetType(), serviceType.Type.GetType());
            //    var desc = new ServiceDescriptor(serviceType.Interface.GetElementType(), serviceType.Type, ServiceLifetime.Scoped);
            //    services.Add(desc);
            //}

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ISubscriptionService, SubscriptionService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IMerchantService, MerchantService>();
            services.AddScoped<ITableDefinitionService, TableDefinitionService>();
            services.AddScoped<ITableHistoryService, TableHistoryService>();
            services.AddScoped<ISmsService, SmsService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBlobFileService, BlobFileService>();
            services.AddScoped<ITariffService, TariffService>();
            services.AddScoped<ICarrierCollectionService, CarrierCollectionService>();
            services.AddScoped<IMerchantPaymentService, MerchantPaymentService>();
        }
    }
}
