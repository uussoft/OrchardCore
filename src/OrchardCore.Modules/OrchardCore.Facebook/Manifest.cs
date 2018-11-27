using OrchardCore.Modules.Manifest;
using OrchardCore.Facebook;

[assembly: Module(
    Name = "Facebook",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Category = "Facebook"
)]

[assembly: Feature(
    Id = FacebookConstants.Features.Core,
    Name = "Facebook",
    Category = "Facebook",
    Description = "Registers the core components used by the Facebook features."
)]

[assembly: Feature(
    Id = FacebookConstants.Features.Login,
    Name = "Facebook Login",
    Category = "Facebook",
    Description = "Auhenticates users from facebook.",
    Dependencies = new[] { FacebookConstants.Features.Core }
)]