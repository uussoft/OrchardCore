using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Html",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The Html module enables content items to have Html bodies.",
    Dependencies = new [] { "OrchardCore.ContentTypes" },
    Category = "内容管理"
)]
