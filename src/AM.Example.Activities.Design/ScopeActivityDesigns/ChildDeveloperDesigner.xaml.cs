using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.ScopeExample;

namespace AM.Example.ActivitiesDesign.ScopeActivityDesigns
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