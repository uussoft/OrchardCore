using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Layers",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Layers",
    Description = "Enables users to render Widgets across pages of the site based on conditions.",
    Dependencies = new []
    {
        "OrchardCore.Widgets",
        "OrchardCore.Scripting"
    },
    Category = "内容管理"
)]
