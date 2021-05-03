using AM.Activities.Example.ErrorMessageExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.ErrorMessageExample
{
    [DeveloperDesigner(
        typeof(ErrorMessageActivity))] // Indicates that this design will be used for the ErrorMessageActivity in the composer
    public partial class ErrorMessageDeveloperDesigner
    {
        public ErrorMessageDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}