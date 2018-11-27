using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Media",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Media",
    Name = "Media",
    Description = "The media module adds media management support.",
    Dependencies = new []
    {
        "OrchardCore.ContentTypes",
        "OrchardCore.Title"
    },
    Category = "内容管理"
)]
