using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Workflows",
    Author = "鼎想网络开发团队",
    Website = "https://www.xuebakutang.com",
    Version = "2.0.0",
    Description = "The Workflows module provides tools and APIs to create custom workflows",
    Category = "工作流"
)]

[assembly: Feature(
    Id = "OrchardCore.Workflows",
    Name = "Workflows",
    Description = "The Workflows module provides tools and APIs to create custom workflows",
    Dependencies = new[] { "OrchardCore.Liquid", "OrchardCore.Scripting" },
    Category = "工作流"
)]

[assembly: Feature(
    Id = "OrchardCore.Workflows.Http",
    Name = "HTTP Workflows Activities",
    Description = "Provides HTTP-related services and activities.",
    Dependencies = new[] { "OrchardCore.Workflows" },
    Category = "工作流"
)]

[assembly: Feature(
    Id = "OrchardCore.Workflows.Timers",
    Name = "Timer Workflow Activities",
    Description = "Provides timer-based services and activities.",
    Dependencies = new[] { "OrchardCore.Workflows" },
    Category = "工作流"
)]