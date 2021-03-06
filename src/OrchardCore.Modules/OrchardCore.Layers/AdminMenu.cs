using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;
using OrchardCore.Layers.Drivers;

namespace OrchardCore.Layers
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

            builder
                .Add(T["配置管理"], configuration => configuration
                    .Add(T["设置"], settings => settings
                        .Add(T["Layers"], T["Layers"], layers => layers
                            .Action("Index", "Admin", new { area = "OrchardCore.Settings", groupId = LayerSiteSettingsDisplayDriver.GroupId })
                            .Permission(Permissions.ManageLayers)
                            .LocalNav()
                        ))
                .Add(T["Layers"], T["Layers"], layers => layers
                        .Permission(Permissions.ManageLayers)
                        .Action("Index", "Admin", new { area = "OrchardCore.Layers" })
                        .LocalNav()
                    ));

            return Task.CompletedTask;
        }
    }
}
