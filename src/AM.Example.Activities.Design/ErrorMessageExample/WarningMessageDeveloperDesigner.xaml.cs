using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.ErrorMessageExample;

namespace AM.Example.ActivitiesDesign.ErrorMessageExample
{
    [DeveloperDesigner(
        typeof(WarningMessageActivity))] // Indicates that this Design will be used for the WarningMessageActivity in the composer
    public partial class WarningMessageDeveloperDesigner
    {
        public WarningMessageDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}