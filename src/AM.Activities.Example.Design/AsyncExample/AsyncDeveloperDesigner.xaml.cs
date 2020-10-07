using AM.Activities.Example.AsyncExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.AsyncExample
{
    [AnalystDesigner(
        typeof(AsyncActivity))]
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