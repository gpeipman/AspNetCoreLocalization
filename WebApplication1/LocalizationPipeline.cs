using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;

namespace WebApplication1
{
    public class LocalizationPipeline
    {
        public void Configure(IApplicationBuilder app)
        {
            var options = new RequestLocalizationOptions();
            ConfigureOptions(options);

            app.UseRequestLocalization(options);
        }

        public static void ConfigureOptions(RequestLocalizationOptions options)
        {
            var supportedCultures = new List<CultureInfo>
                                {
                                    new CultureInfo("en"),
                                    new CultureInfo("et"),
                                    new CultureInfo("ru"),
                                };

            options.DefaultRequestCulture = new RequestCulture(culture: "en", uiCulture: "en");
            options.SupportedCultures = supportedCultures;
            options.SupportedUICultures = supportedCultures;
            options.RequestCultureProviders = new[] {
                new RouteDataRequestCultureProvider()
                {
                    Options = options,
                    RouteDataStringKey = "lang",
                    UIRouteDataStringKey = "lang"
                }
            };
        }
    }
}
