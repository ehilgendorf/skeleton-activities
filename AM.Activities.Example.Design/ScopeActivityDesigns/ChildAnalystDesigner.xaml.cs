using AM.Activities.Example.ScopeExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.ScopeActivityDesigns
{
    [AnalystDesigner(
        typeof(ChildActivity))] // Indicates that this Design will be used for the Analyst view in the composer
    public partial class ChildAnalystDesigner
    {
        public ChildAnalystDesigner()
        {
            InitializeComponent();
        }
    }
}