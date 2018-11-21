using OrchardCore.ContentManagement.Handlers;
using System.Threading.Tasks;
using OrchardCore.Course.Models;

namespace OrchardCore.Course.Handlers
{
    public class TestPartPartHandler : ContentPartHandler<TestPartPart>
    {
        public override Task InitializingAsync(InitializingContentContext context, TestPartPart part)
        {
            part.Show = true;

            return Task.CompletedTask;
        }
    }
}