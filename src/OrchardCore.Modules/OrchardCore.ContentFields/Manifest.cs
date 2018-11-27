using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "内容字段",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "此模块可以给内容添加自定义字段",
    Dependencies = new [] { "OrchardCore.ContentTypes" },
    Category = "内容管理"
)]
