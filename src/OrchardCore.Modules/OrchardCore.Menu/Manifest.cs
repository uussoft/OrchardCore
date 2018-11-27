using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Menu",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The Menu module provides menu management features.",
    Dependencies = new []
    {
        "OrchardCore.Contents",
        "OrchardCore.Title",
        "OrchardCore.Alias"
    },
    Category = "Navigation"
)]
