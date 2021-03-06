using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Alias.Models;
using OrchardCore.Apis;
using OrchardCore.Apis.GraphQL.Queries;
using OrchardCore.Modules;

namespace OrchardCore.Alias.GraphQL
{
    [RequireFeatures("OrchardCore.Apis.GraphQL")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddObjectGraphType<AliasPart, AliasQueryObjectType>();
            services.AddInputObjectGraphType<AliasPart, AliasInputObjectType>();
            services.AddTransient<IIndexAliasProvider, AliasPartIndexAliasProvider>();
        }
    }
}
