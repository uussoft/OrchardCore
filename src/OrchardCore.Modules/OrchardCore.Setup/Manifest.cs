using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "安装模块",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "提供应用程序安装体验",
    Dependencies = new[] { "OrchardCore.Recipes" },
    Category = "基础功能"
)]
