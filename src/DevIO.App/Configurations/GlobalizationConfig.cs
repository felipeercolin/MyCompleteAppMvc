using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

namespace DevIO.App.Configurations
{
    public static class GlobalizationConfig
    {
        public static IApplicationBuilder UseGlobaliztionConfiguration(this IApplicationBuilder app)
        {

            var defaultCulture = new System.Globalization.CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<System.Globalization.CultureInfo>(1) { defaultCulture },
                SupportedUICultures = new List<System.Globalization.CultureInfo>(1) { defaultCulture },
            };
            app.UseRequestLocalization(localizationOptions);

            return app;
        }
    }
}