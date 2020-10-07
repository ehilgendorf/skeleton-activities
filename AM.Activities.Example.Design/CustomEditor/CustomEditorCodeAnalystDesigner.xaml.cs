using AM.Activities.Example.CustomEditor;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.CustomEditor
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