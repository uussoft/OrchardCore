using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Title",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The title module enables content items to have titles.",
    Dependencies = new[] { "OrchardCore.Contents" },
    Category = "内容管理"
)]
