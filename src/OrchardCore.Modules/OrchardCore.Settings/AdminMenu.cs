using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace OrchardCore.Settings
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

            builder.Add(T["配置管理"], configuration => configuration
                .Add(T["设置"], "1", settings => settings
                    .Add(T["站点设置"], T["站点设置"], entry => entry
                        .Action("Index", "Admin", new { area = "OrchardCore.Settings", groupId = "general" })
                        .Permission(Permissions.ManageGroupSettings)
                        .LocalNav()
                    )
                )
            );

            return Task.CompletedTask;
        }
    }
}