using Hayalpc.Dcb.Common.Helpers;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Microsoft.Extensions.DependencyInjection;
using Hayalpc.Dcb.Panel.External.Helpers;
using Hayalpc.Dcb.Panel.External.Resources;

namespace Hayalpc.Dcb.Panel.External.Extensions
{
    public static class ScopeExtension
    {
        public static void AddScopes(this IServiceCollection services)
        {
            services.AddScoped<IHpLogger, NlogImpl>();
            services.AddScoped<Hayalpc.Library.Common.Helpers.Interfaces.IHtttpClientCreator, Dcb.Panel.External.Helpers.HtttpClientCreator>();
            services.AddScoped<Hayalpc.Library.Common.Helpers.Interfaces.IHttpClientHelper, Library.Common.Helpers.HttpClientHelper>();
            services.AddScoped<ISessionHelper, SessionHelper>();

            services.AddScoped<Hayalpc.Library.Common.Helpers.Interfaces.IBlobStorageHelper, Hayalpc.Library.Common.Helpers.AzureBlobHelper>();

            services.AddSingleton<LocService>();
        }

    }
}
