using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Custom Settings",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The custom settings modules enables content types to become custom site settings.",
    Dependencies = new [] { "OrchardCore.Contents" },
    Category = "Settings"
)]
