using System.Activities.Presentation.PropertyEditing;
using System.Windows;
using System.Windows.Forms;
using AM.Skeleton.Activities.Design.CustomEditor.Resources;

namespace AM.Skeleton.Activities.Design.CustomEditor
{
    /// <summary>
    ///     An example of how to create a custom editor that will be shown in the property panel.
    ///     In this case, we create an expression text-box with a button.
    /// </summary>
    public class FileBrowserDialogEditor : DialogPropertyValueEditor
    {
        public FileBrowserDialogEditor()
        {
            // Get the XAML DataTemplate for this control
            InlineEditorTemplate = (DataTemplate) EditorResources.GetResources()["ExampleEditor"];
        }

        /// <summary>
        ///     Shows the dialog when the EditModeSwitchButton event is triggered
        /// </summary>
        /// <param name="propertyValue">Maintains a data model for the value of a property in the property grid.</param>
        /// <param name="commandSource">
        ///     Establishes the common events and also the event-related properties and methods for basic
        ///     input processing by Windows Presentation Foundation (WPF) elements.
        /// </param>
        public override void ShowDialog(PropertyValue propertyValue,
            IInputElement commandSource)
        {
            // Instead of a Open File dialog you can start a custom window
            OpenFileDialog browse = new OpenFileDialog();

            if (browse.ShowDialog() == DialogResult.OK) propertyValue.StringValue = browse.FileName;

            browse.Dispose();
        }
    }
}