using AM.Activities.Example.AsyncExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.AsyncExample
{
    [AnalystDesigner(
        typeof(AsyncWithResultActivity))] // Indicates that this Design will be used for the Analyst view in the composer
    public partial class AsyncWithResultAnalystDesigner
    {
        public AsyncWithResultAnalystDesigner()
        {
            InitializeComponent();
        }
    }
}