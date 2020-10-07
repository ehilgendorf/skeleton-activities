using AM.ComposerActivitiesBridge.Attributes;
using AM.Skeleton.Activities.ScopeExample;

namespace AM.Skeleton.Activities.Design.ScopeActivityDesigns
{
    [DeveloperDesigner(
        typeof(ChildActivity))] // Indicates that this Design will be used for the Developer view in the composer
    public partial class ChildDeveloperDesigner
    {
        public ChildDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}