using AM.Activities.Example.AsyncExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.AsyncExample
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