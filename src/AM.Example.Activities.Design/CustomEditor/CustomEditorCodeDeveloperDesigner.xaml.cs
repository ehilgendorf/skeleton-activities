using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.CustomEditor;

namespace AM.Example.ActivitiesDesign.CustomEditor
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