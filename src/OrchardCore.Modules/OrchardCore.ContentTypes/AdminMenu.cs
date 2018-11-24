using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;
using System;
using System.Threading.Tasks;

namespace OrchardCore.ContentTypes {
    public class AdminMenu : INavigationProvider {

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

            builder.Add(T["内容定义"], "2", contentDefinition => contentDefinition
                .AddClass("content-definition").Id("contentdefinition")
                .LinkToFirstChild(true)
                    .Add(T["内容类型"], "1", contentTypes => contentTypes
                        .Action("List", "Admin", new { area = "OrchardCore.ContentTypes" })
                        .Permission(Permissions.ViewContentTypes)
                        .LocalNav())
                    .Add(T["内容部件"], "2", contentParts => contentParts
                        .Action("ListParts", "Admin", new { area = "OrchardCore.ContentTypes" })
                        .Permission(Permissions.ViewContentTypes)
                        .LocalNav())
                    );

            return Task.CompletedTask;
        }
    }
}