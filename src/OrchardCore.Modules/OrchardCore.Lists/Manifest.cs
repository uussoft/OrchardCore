using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Lists",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Lists",
    Name = "Lists",
    Description = "Introduces a preconfigured container-enabled content type.",
    Dependencies = new [] { "OrchardCore.ContentTypes" },
    Category = "内容管理"
)]
