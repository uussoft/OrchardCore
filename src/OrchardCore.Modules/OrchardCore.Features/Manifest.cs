using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Features",
    Author = "The Orchard Team",
    Website = "http://orchardproject.net",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Features",
    Name = "功能管理",
    Description = "此功能模块可以使站点管理员管理已安装的模块以及激活和取消激活功能",
    Dependencies = new [] { "OrchardCore.Resources" },
    Category = "基础功能"
)]
