using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OrchardCore.Course.Settings
{
    public class TestPartPartSettingsViewModel
    {
        public string MySetting { get; set; }

        [BindNever]
        public TestPartPartSettings TestPartPartSettings { get; set; }
    }
}
