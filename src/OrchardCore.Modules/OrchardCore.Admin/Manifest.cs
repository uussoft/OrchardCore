using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Admin",
    Author = "The Orchard Team",
    Website = "http://orchardproject.net",
    Version = "2.0.0",
    Description = "Creates an admin section for the site.",
    Category = "基础设施",
    Dependencies = new[]
    {
        "OrchardCore.Settings"
    }
)]
