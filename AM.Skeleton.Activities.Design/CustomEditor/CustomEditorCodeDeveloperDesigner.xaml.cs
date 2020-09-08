using AM.DefaultActivities.Design.Attributes;
using AM.Skeleton.Activities.CustomEditor;

namespace AM.Skeleton.Activities.Design.CustomEditor
{
    [DeveloperDesigner(
        typeof(CustomEditorCodeActivity))] // Indicates that this Design will be used for the Developer view in the composer
    public partial class CustomEditorCodeDeveloperDesigner
    {
        public CustomEditorCodeDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}