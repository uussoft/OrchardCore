using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "XML-RPC",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = "OrchardCore.XmlRpc",
    Name = "XML-RPC",
    Description = "XML-RPC模块支持从客户端应用程序（如Open Live Writer）创建内容。",
    Category = "基础功能"
)]

[assembly: Feature(
    Id = "OrchardCore.RemotePublishing",
    Name = "远程发布",
    Description = "远程发布功能支持从客户端应用程序（如Open Live Writer）创建内容。",
    Dependencies = new [] { "OrchardCore.XmlRpc" },
    Category = "基础功能"
)]
