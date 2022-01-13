using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

namespace Example.MyMongo.Extensions
{
    public static class SwaggerExtensions
    {

        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(e =>
            {
                e.UseInlineDefinitionsForEnums();
            });
            return services;
        }
        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app, string appNamespace)
        {
            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((document, request) =>
                {
                    var address = $"{request.Host.Value}/{(!request.Host.Host.Equals("localhost", StringComparison.OrdinalIgnoreCase) ? appNamespace : string.Empty)}";
                    document.Servers = new List<OpenApiServer>
                    {
                         new OpenApiServer {Url = $"https://{address}"},
                         new OpenApiServer {Url = $"http://{address}"},
                    };
                });
            });

            app.UseSwaggerUI();
            
            return app;
        }
    }
}
