using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.AsyncExample;

namespace AM.Example.ActivitiesDesign.AsyncExample
{
    [DeveloperDesigner(
        typeof(AsyncActivity))] // Indicates that this Design will be used for the Developer view in the composer
    public partial class AsyncDeveloperDesigner
    {
        public AsyncDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}