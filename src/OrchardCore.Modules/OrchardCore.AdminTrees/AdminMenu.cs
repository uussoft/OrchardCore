using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.AdminTrees.Services;
using OrchardCore.Navigation;

namespace OrchardCore.AdminTrees
{
    public class AdminMenu : INavigationProvider
    {
        private readonly AdminTreeNavigationProvidersCoordinator _adminTreeNavigationProvider;

        public AdminMenu(AdminTreeNavigationProvidersCoordinator adminTreeNavigationProvider,
            IStringLocalizer<AdminMenu> localizer)
        {
            _adminTreeNavigationProvider = adminTreeNavigationProvider;
            T = localizer;
        }

        public IStringLocalizer T { get; set; }

        public async Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            // Configuration and settings menus for the AdminTree module
            builder.Add(T["配置管理"], cfg => cfg
                    .Add(T["Admin Trees"], "1.5", admt => admt
                        .Permission(Permissions.ManageAdminTree)
                        .Action("List", "Tree", new { area = "OrchardCore.AdminTrees" })
                        .LocalNav()
                    ));

            // This is the entry point for the adminTree: dynamically generated custom admin menus
           await  _adminTreeNavigationProvider.BuildNavigationAsync("admintree", builder);            
        }
    }
}
