using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Remote Deployment",
    Author = "�������翪���Ŷ�",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "Provide the ability to export and import to and from a remote server.",
    Dependencies = new [] { "OrchardCore.Deployment" },
    Category = "Deployment"
)]
