using AM.Skeleton.Activities.AsyncExample;
using AM.DefaultActivities.Design.Attributes;

namespace AM.Skeleton.Activities.Design.AsyncExample
{
    [AnalystDesigner(
        typeof(AsyncActivity))] // Indicates that this Design will be used for the Analyst view in the composer
    public partial class AsyncAnalystDesigner
    {
        public AsyncAnalystDesigner()
        {
            InitializeComponent();
        }
    }
}