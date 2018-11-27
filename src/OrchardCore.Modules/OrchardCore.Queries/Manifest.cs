using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Queries",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Queries",
    Name = "Queries",
    Description = "Provides querying capabilities.",
    Dependencies = new [] { "OrchardCore.Liquid" },
    Category = "内容管理"
)]

[assembly: Feature(
    Id = "OrchardCore.Queries.Sql",
    Name = "SQL Queries",
    Description = "Introduces a way to create custom Queries in pure SQL.",
    Dependencies = new [] { "OrchardCore.Queries" },
    Category = "内容管理"
)]
