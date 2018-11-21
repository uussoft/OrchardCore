using System;
using System.Threading.Tasks;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Course.Models;

namespace OrchardCore.Course.Settings
{
    public class TestPartPartSettingsDisplayDriver : ContentPartDefinitionDisplayDriver
    {
        public override IDisplayResult Edit(ContentPartDefinition contentPartDefinition)
        {
            if (!String.Equals(nameof(TestPartPart), contentPartDefinition.Name, StringComparison.Ordinal))
            {
                return null;
            }

            return Initialize<TestPartPartSettingsViewModel>("TestPartPartSettings_Edit", model =>
            {
                var settings = contentPartDefinition.GetSettings<TestPartPartSettings>();

                model.MySetting = settings.MySetting;
                model.TestPartPartSettings = settings;

                return Task.CompletedTask;
            }).Location("Content");
        }

        public override async Task<IDisplayResult> UpdateAsync(ContentPartDefinition contentPartDefinition, UpdatePartEditorContext context)
        {
            if (!String.Equals(nameof(TestPartPart), contentPartDefinition.Name, StringComparison.Ordinal))
            {
                return null;
            }

            var model = new TestPartPartSettingsViewModel();

            if (await context.Updater.TryUpdateModelAsync(model, Prefix, m => m.MySetting))
            {
                context.Builder.WithSettings(new TestPartPartSettings { MySetting = model.MySetting });
            }

            return Edit(contentPartDefinition, context.Updater);
        }
    }
}