using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "站点安装模块",
    Author = "The Orchard Team",
    Website = "http://orchardproject.net",
    Version = "2.0.0",
    Description = "The setup module is creating the application's setup experience.",
    Dependencies = new[] { "OrchardCore.Recipes" },
    Category = "基础功能"
)]
