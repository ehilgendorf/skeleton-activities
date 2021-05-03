using AM.Activities.Example.CustomEditor;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.CustomEditor
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