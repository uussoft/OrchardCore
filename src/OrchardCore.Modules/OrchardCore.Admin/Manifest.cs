using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "后台管理",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "为站点创建后台管理功能",
    Category = "基础功能",
    Dependencies = new[]
    {
        "OrchardCore.Settings"
    }
)]
