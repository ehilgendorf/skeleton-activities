using AM.ComposerActivitiesBridge.Attributes;
using AM.Skeleton.Activities.ScopeExample;

namespace AM.Skeleton.Activities.Design.ScopeActivityDesigns
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