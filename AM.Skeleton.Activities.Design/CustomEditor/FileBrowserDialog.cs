using System.Activities.Presentation.PropertyEditing;
using System.Windows;
using System.Windows.Forms;

namespace AM.Skeleton.Activities.Design.CustomEditor
{
    /// <summary>
    /// 
    /// </summary>
    public class FileBrowserDialogEditor : DialogPropertyValueEditor
    {
        public FileBrowserDialogEditor()
        {
            InlineEditorTemplate = (DataTemplate) EditorResources.GetResources()["ExampleEditor"];
        }

        public override void ShowDialog(PropertyValue propertyValue,
            IInputElement commandSource)
        {
            // Instead of a Open File dialog you can start a Custom Window
            OpenFileDialog browse = new OpenFileDialog();

            if (browse.ShowDialog() == DialogResult.OK) propertyValue.StringValue = browse.FileName;
            browse.Dispose();
        }
    }
}