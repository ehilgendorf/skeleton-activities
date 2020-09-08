using AM.DefaultActivities.Design.Attributes;
using AM.Skeleton.Activities.AsyncExample;

namespace AM.Skeleton.Activities.Design.AsyncExample
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