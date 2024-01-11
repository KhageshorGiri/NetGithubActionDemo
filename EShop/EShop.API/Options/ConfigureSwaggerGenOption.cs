using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace EShop.API.Options
{
    public class ConfigureSwaggerGenOption : IConfigureOptions<SwaggerGenOptions>
    {

        private readonly IApiVersionDescriptionProvider _apiVersionProvider;

        public ConfigureSwaggerGenOption(IApiVersionDescriptionProvider apiVersionProvider)
        {
            _apiVersionProvider = apiVersionProvider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach(var description in _apiVersionProvider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName,  CreateVersionInfo(description));
            }
        }

        private OpenApiInfo CreateVersionInfo(ApiVersionDescription apiVersionDescription)
        {
            var info = new OpenApiInfo()
            {
                Title = "EShop",
                Version = apiVersionDescription.ApiVersion.ToString()
            };

            if (apiVersionDescription.IsDeprecated)
            {
                info.Description = "This Api Version has been Deprecated";
            }
            return info;
        }
    }
}
