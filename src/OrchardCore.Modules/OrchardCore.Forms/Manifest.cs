using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Forms",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Forms",
    Name = "Forms",
    Description = "Provides widgets and activities to implement forms.",
    Dependencies = new [] { "OrchardCore.Widgets", "OrchardCore.Flows" },
    Category = "内容管理"
)]