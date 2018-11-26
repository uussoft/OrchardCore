using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "后台管理",
    Author = "The Orchard Team",
    Website = "http://orchardproject.net",
    Version = "2.0.0",
    Description = "为站点创建后台管理功能",
    Category = "基础功能",
    Dependencies = new[]
    {
        "OrchardCore.Settings"
    }
)]
