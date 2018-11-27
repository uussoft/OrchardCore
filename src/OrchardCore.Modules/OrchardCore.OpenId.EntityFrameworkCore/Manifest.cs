using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "OpenID Entity Framework Core Stores",
    Author = "�������翪���Ŷ�",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "Provides an Entity Framework Core 2.x adapter for the OpenID module.",
    Dependencies = new[] { "OrchardCore.OpenId.Management" },
    Category = "OpenID Connect"
)]
