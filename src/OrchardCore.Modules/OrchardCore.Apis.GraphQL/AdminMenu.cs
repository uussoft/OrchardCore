using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace OrchardCore.Apis.GraphQL
{
    public class AdminMenu : INavigationProvider
    {
        public AdminMenu(IStringLocalizer<AdminMenu> localizer)
        {
            T = localizer;
        }

        public IStringLocalizer T { get; set; }
        
        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return Task.CompletedTask;
            }

            builder.Add(T["配置管理"], "10", design => design
                    .AddClass("menu-configuration").Id("configuration")
                    .Add(T["GraphiQL"], "5", deployment => deployment
                        .Action("Index", "Admin", new { area = "OrchardCore.Apis.GraphQL" })
                        .Permission(Permissions.ExecuteGraphQL)
                        .LocalNav()
                    )
                );

            return Task.CompletedTask;
        }
    }
}
