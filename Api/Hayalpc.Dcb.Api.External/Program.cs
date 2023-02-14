using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ocelot.Middleware;
using Ocelot.DependencyInjection;
using Hayalpc.Library.Common.Helpers;

namespace Hayalpc.Dcb.Api.External
{
    public class Program
    {
        private static IConfiguration _configuration;

        public static void Main(string[] args)
        {
            var isService = !(Debugger.IsAttached || args.Contains("--console"));

            bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

            var host = CreateHostBuilder(args).Build();

            if (isWindows && isService)
                host.RunAsService();
            else
                host.Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();

            var webSettings = new WebHostSettingHelper();
            config.GetSection("WebHostSettings").Bind(webSettings);

            var host = new WebHostBuilder()
            .UseKestrel(
            o =>
            {
                o.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(15);
                o.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(30);
                o.Limits.MaxConcurrentConnections = 1000;
            })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath);
                config.AddJsonFile("appsettings.json", true, true);
                config.AddJsonFile("ocelot.json");
                config.AddEnvironmentVariables(prefix: "ASPNETCORE_");

                _configuration = config.Build();
            })
            .ConfigureServices(s =>
            {
                s.AddOcelot(_configuration);
            })
            .Configure(app =>
            {
                app.UseOcelot().Wait();
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();

                logging.AddDebug();
                logging.AddConsole();
            })
            .UseIIS()
            .UseIISIntegration()
            .UseUrls(webSettings.Urls);

            return host;
        }
    }
}
