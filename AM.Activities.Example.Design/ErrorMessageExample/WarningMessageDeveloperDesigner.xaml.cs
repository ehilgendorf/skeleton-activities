using AM.ComposerActivitiesBridge.Attributes;
using AM.Skeleton.Activities.ErrorMessageExample;

namespace AM.Skeleton.Activities.Design.ErrorMessageExample
{
    [DeveloperDesigner(
        typeof(WarningMessageActivity))] // Indicates that this Design will be used for the Developer view in the composer
    public partial class WarningMessageDeveloperDesigner
    {
        public WarningMessageDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}