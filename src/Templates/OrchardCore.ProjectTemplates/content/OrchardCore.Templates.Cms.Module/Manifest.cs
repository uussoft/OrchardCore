using OrchardCore.Modules.Cms.Manifest;

[assembly: Module(
    Name = "OrchardCore.Templates.Module",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "0.0.1",
    Description = "OrchardCore.Templates.Module",
#if (AddPart)
    Dependencies = new[] { "OrchardCore.Contents" },
#endif
    Category = "内容管理"
)]
