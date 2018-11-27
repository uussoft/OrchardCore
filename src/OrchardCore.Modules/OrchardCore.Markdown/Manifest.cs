using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Markdown",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The markdown module enables content items to have markdown editors.",
    Dependencies = new [] { "OrchardCore.ContentTypes" },
    Category = "内容管理"
)]
