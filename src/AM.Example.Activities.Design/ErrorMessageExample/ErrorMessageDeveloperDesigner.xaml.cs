using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.ErrorMessageExample;

namespace AM.Example.ActivitiesDesign.ErrorMessageExample
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