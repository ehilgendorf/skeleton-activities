using AM.Activities.Example.ScopeExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.ScopeActivityDesigns
{
    [DeveloperDesigner(
        typeof(ChildActivity))] // Indicates that this Design will be used for the ChildActivity in the composer
    public partial class ChildDeveloperDesigner
    {
        public ChildDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}