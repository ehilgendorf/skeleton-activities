using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.AsyncExample;

namespace AM.Example.ActivitiesDesign.AsyncExample
{
    [DeveloperDesigner(
        typeof(AsyncWithResultActivity))] // Indicates that this Design will be used for the Developer view in the composer
    public partial class AsyncWithResultDeveloperDesigner
    {
        public AsyncWithResultDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}