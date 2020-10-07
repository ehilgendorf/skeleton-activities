using AM.Activities.Example.ErrorMessageExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.ErrorMessageExample
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