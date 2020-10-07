using AM.Activities.Example.ErrorMessageExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.ErrorMessageExample
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