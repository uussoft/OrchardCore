using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Email",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "Provides email settings configuration and a default email service based on SMTP.",
    Dependencies = new [] { "OrchardCore.Resources" },
    Category = "Messaging"
)]
