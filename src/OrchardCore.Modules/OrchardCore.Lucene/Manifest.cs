using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Lucene",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Lucene",
    Name = "Lucene",
    Description = "Creates Lucene indexes to support search scenarios, introduces a preconfigured container-enabled content type.",
    Dependencies = new[]
    {
        "OrchardCore.Indexing",
        "OrchardCore.Liquid"
    },
    Category = "内容管理"
)]

[assembly: Feature(
    Id = "OrchardCore.Lucene.Worker",
    Name = "Lucene Worker",
    Description = "Provides a background task to keep local indices in sync with other instances.",
    Dependencies = new[] { "OrchardCore.Lucene" },
    Category = "内容管理"
)]

[assembly: Feature(
    Id = "OrchardCore.Lucene.ContentPicker",
    Name = "Lucene Content Picker",
    Description = "Provides a Lucene content picker field editor.",
    Dependencies = new[] { "OrchardCore.Lucene", "OrchardCore.ContentFields" },
    Category = "内容管理"
)]
