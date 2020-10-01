using AM.ComposerActivitiesBridge.Attributes;
using AM.Skeleton.Activities.ErrorMessageExample;

namespace AM.Skeleton.Activities.Design.ErrorMessageExample
{
    [AnalystDesigner(
        typeof(ErrorMessageActivity))] // Indicates that this Design will be used for the Analyst view in the composer
    public partial class ErrorMessageAnalystDesigner
    {
        public ErrorMessageAnalystDesigner()
        {
            InitializeComponent();
        }
    }
}