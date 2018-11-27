using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "别名模块",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "使内容具有逻辑标识符",
    Dependencies = new [] { "OrchardCore.ContentTypes" },
    Category = "内容管理"
)]
