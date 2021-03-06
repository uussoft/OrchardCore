using System.Collections.Generic;
using OrchardCore.Environment.Extensions.Features;

namespace OrchardCore.Features.Models 
{
    /// <summary>
    /// 表示模块的功能
    /// </summary>
    public class ModuleFeature 
    {
        /// <summary>
        /// 功能特征描述
        /// </summary>
        public IFeatureInfo Descriptor  { get; set; }

        /// <summary>
        /// Boolean value indicating if the feature is enabled.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Boolean value indicating if the feature needs a data update / migration.
        /// </summary>
        public bool NeedsUpdate { get; set; }

        /// <summary>
        /// Boolean value indicating if the module needs a version update.
        /// </summary>
        public bool NeedsVersionUpdate { get; set; }

        /// <summary>
        /// Boolean value indicating if the feature was recently installed.
        /// </summary>
        public bool IsRecentlyInstalled { get; set; }

        /// <summary>
        /// List of features that depend on this feature.
        /// </summary>
        public IEnumerable<IFeatureInfo> DependentFeatures { get; set; }

        /// <summary>
        /// List of features that this feature depends on.
        /// </summary>
        public IEnumerable<IFeatureInfo> FeatureDependencies { get; set; }
    }
}