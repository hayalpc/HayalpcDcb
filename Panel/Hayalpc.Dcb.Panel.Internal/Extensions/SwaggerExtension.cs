using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.OpenApi.Models;

using System;

namespace Hayalpc.Dcb.Panel.Internal.Extensions
{
    public static class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
/*
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "1.0.0",
                    Title = "API Documentation",
                    Description = "API",
                    TermsOfService = new Uri("https://xxxx.com"),
                    Contact = new OpenApiContact
                    {
                        Name = "Erdinç Karaman",
                        Email = "ekaraman@xxxx.com",
                        Url = new Uri("https://xxxx.com")
                    }
                });
                c.AddSecurityDefinition("Bearer",
                  new OpenApiSecurityScheme
                  {
                      In = ParameterLocation.Header,
                      Description = "Please enter into field the word 'Bearer' following by space and JWT",
                      Name = "Authorization",
                      Type = SecuritySchemeType.ApiKey,
                      Scheme = "Bearer"
                  });
            });
*/
        }

        public static void AddUseSwagger(this IApplicationBuilder app, string version)
        {
/*
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", version);
            });
*/

        }
    }
}
