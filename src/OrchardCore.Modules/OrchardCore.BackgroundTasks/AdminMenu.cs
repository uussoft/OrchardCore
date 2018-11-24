using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace OrchardCore.BackgroundTasks
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
                    .Add(T["任务管理"], "10", tasks => tasks
                        .Add(T["后台任务"], "10", backgroundTasks => backgroundTasks
                            .Action("Index", "BackgroundTask", new { area = "OrchardCore.BackgroundTasks" })
                            .Permission(Permissions.ManageBackgroundTasks)
                            .LocalNav()
                        )
                    )
                );

            return Task.CompletedTask;
        }
    }
}
