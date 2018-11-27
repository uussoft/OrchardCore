using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "内容预览",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "此模块支持实时内容编辑和内容预览",
    Dependencies = new [] { "OrchardCore.Contents" },
    Category = "内容管理"
)]
