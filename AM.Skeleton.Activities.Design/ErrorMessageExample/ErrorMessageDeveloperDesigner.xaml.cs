using AM.DefaultActivities.Design;
using AM.Skeleton.Activities.ErrorMessageExample;

namespace AM.Skeleton.Activities.Design.ErrorMessageExample
{
    [DeveloperDesigner(
        typeof(ErrorMessageActivity))] // Indicates that this Design will be used for the Developer view in the composer
    public partial class ErrorMessageDeveloperDesigner
    {
        public ErrorMessageDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}