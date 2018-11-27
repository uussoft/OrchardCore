using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Liquid",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The liquid module enables content items to have liquid syntax.",
    Dependencies = new[] { "OrchardCore.Contents" },
    Category = "内容管理"
)]
