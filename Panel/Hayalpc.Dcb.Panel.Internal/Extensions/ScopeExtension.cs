using Hayalpc.Library.Common.Helpers;
using Hayalpc.Library.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Microsoft.Extensions.DependencyInjection;
using Hayalpc.Dcb.Panel.Internal.Helpers;
using Hayalpc.Dcb.Common.Helpers;

namespace Hayalpc.Dcb.Panel.Internal.Extensions
{
    public static class ScopeExtension
    {
        public static void AddScopes(this IServiceCollection services)
        {
            services.AddScoped<IHpLogger, NlogImpl>();
            services.AddScoped<ITokenCreator, TokenCreator>();
            services.AddScoped<Dcb.Panel.Internal.Helpers.Interfaces.IMailHelper, Dcb.Panel.Internal.Helpers.MailHelper>();
            services.AddScoped<Hayalpc.Library.Common.Helpers.Interfaces.IHtttpClientCreator, HttpClientCreator>();
            services.AddScoped<Hayalpc.Library.Common.Helpers.Interfaces.IHttpClientHelper, Library.Common.Helpers.HttpClientHelper>();
        }

    }
}
