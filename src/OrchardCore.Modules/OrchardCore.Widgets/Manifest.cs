using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Widgets",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Widgets",
    Description = "Provides a part allowing content items to render Widgets in theme zones.",
    Dependencies = new [] { "OrchardCore.ContentTypes" },
    Category = "内容管理"
)]
