using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "内容类型",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "此模块允许创建和更改不基于代码的内容类型",
    Dependencies = new [] { "OrchardCore.Contents" },
    Category = "内容管理"
)]
