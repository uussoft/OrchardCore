using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Templates",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The Templates module provides a way to write custom shape templates from the admin.",
    Dependencies = new [] { "OrchardCore.Liquid" },
    Category = "Development"
)]
