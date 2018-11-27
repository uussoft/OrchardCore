using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Recipes",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "Provides Orchard Recipes.",
    Dependencies = new []
    {
        "OrchardCore.Features",
        "OrchardCore.Scripting"
    },
    Category = "基础功能"
)]
