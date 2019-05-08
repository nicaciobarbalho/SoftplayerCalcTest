using System.Web.Http;
using WebActivatorEx;
using SoftplayerCalcTest;
using Swashbuckle.Application;
using System.Linq;
using System;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SoftplayerCalcTest
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "SoftplayerCalcTest");

                    c.IgnoreObsoleteActions();
                    c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\Swagger.xml");
                    c.IgnoreObsoleteProperties();

                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                })
                .EnableSwaggerUi(c =>
                {
                    c.DocumentTitle("Utilização do Swagger");
                    c.DocExpansion(DocExpansion.List);
                });
        }
    }
}
