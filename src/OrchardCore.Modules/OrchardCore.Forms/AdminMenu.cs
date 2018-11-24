using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;
using OrchardCore.Forms.Drivers;

namespace OrchardCore.Forms
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
                        .Add(T["表单设计"], T["表单设计"], forms => forms
                            .Action("Index", "Admin", new { area = "OrchardCore.Settings", groupId = NoCaptchaSettingsDisplay.GroupId })
                            .LocalNav()
                        )));

            return Task.CompletedTask;
        }
    }
}
