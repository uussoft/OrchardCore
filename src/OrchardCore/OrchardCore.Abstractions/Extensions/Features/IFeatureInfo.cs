namespace OrchardCore.Environment.Extensions.Features
{
    /// <summary>
    /// 功能信息的描述接口
    /// </summary>
    public interface IFeatureInfo
    {
        string Id { get; }
        string Name { get; }
        int Priority { get; }
        string Category { get; }
        string Description { get; }
        bool DefaultTenantOnly { get; }
        IExtensionInfo Extension { get; }
        string[] Dependencies { get; }
    }
}
