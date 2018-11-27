using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Microsoft Azure Media",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.Media.Azure.Storage",
    Name = "Azure Media Storage",
    Description = "Enables support for storing media files in, and serving them to clients directly from, Microsoft Azure Blob Storage.",
    Category = "Hosting"
)]
