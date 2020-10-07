
using AM.ComposerActivitiesBridge.Attributes;
using AM.Skeleton.Activities.CustomEditor;

namespace AM.Skeleton.Activities.Design.CustomEditor
{
    [AnalystDesigner(
        typeof(CustomEditorCodeActivity))] // Indicates that this Design will be used for the Analyst view in the composer
    public partial class CustomEditorCodeAnalystDesigner
    {
        public CustomEditorCodeAnalystDesigner()
        {
            InitializeComponent();
        }
    }
}