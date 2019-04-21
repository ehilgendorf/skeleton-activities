using AM.Core.ActivityDesignBase;
using AM.Skeleton.Activities.AsyncExample;

namespace AM.Skeleton.Activities.Design.AsyncExample
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