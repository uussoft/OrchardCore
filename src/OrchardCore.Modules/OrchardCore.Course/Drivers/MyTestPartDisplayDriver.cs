using System.Linq;
using System.Threading.Tasks;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Course.Models;
using OrchardCore.Course.Settings;
using OrchardCore.Course.ViewModels;

namespace OrchardCore.Course.Drivers
{
    public class TestPartPartDisplayDriver : ContentPartDisplayDriver<TestPartPart>
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public TestPartPartDisplayDriver(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public override IDisplayResult Display(TestPartPart TestPartPart)
        {
            return Combine(
                Initialize<TestPartPartViewModel>("TestPartPart", m => BuildViewModel(m, TestPartPart))
                    .Location("Detail", "Content:20"),
                Initialize<TestPartPartViewModel>("TestPartPart_Summary", m => BuildViewModel(m, TestPartPart))
                    .Location("Summary", "Meta:5")
            );
        }
        
        public override IDisplayResult Edit(TestPartPart TestPartPart)
        {
            return Initialize<TestPartPartViewModel>("TestPartPart_Edit", m => BuildViewModel(m, TestPartPart));
        }

        public override async Task<IDisplayResult> UpdateAsync(TestPartPart model, IUpdateModel updater)
        {
            var settings = GetTestPartPartSettings(model);

            await updater.TryUpdateModelAsync(model, Prefix, t => t.Show);
            
            return Edit(model);
        }

        public TestPartPartSettings GetTestPartPartSettings(TestPartPart part)
        {
            var contentTypeDefinition = _contentDefinitionManager.GetTypeDefinition(part.ContentItem.ContentType);
            var contentTypePartDefinition = contentTypeDefinition.Parts.FirstOrDefault(p => p.PartDefinition.Name == nameof(TestPartPart));
            var settings = contentTypePartDefinition.GetSettings<TestPartPartSettings>();

            return settings;
        }

        private Task BuildViewModel(TestPartPartViewModel model, TestPartPart part)
        {
            var settings = GetTestPartPartSettings(part);

            model.ContentItem = part.ContentItem;
            model.MySetting = settings.MySetting;
            model.Show = part.Show;
            model.TestPartPart = part;
            model.Settings = settings;

            return Task.CompletedTask;
        }
    }
}
