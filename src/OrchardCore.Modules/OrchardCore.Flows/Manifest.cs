using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Flows",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Flows",
    Description = "Provides a content part allowing users to edit their content based on Widgets.",
    Dependencies = new [] { "OrchardCore.Widgets" },
    Category = "内容管理"
)]
