using System.Activities;
using System.Activities.Presentation.PropertyEditing;
using System.ComponentModel;
using System.Windows.Forms;
using AM.Activities.Common.BaseActivities;
using AM.Activities.Common.Design.Editors;

namespace AM.Activities.Example.CustomEditor
{
    /// <summary>
    ///     Example of how to create custom editors for arguments
    /// </summary>
    public sealed class CustomEditorCodeActivity : AbstractCodeActivity
    {
        /// <summary>
        ///     InArguments can be displayed with a custom editor to add more functionality. In this case it will show a
        ///     FileDialog
        /// </summary>
        [Editor(typeof(FileBrowserDialogEditor<OpenFileDialog>), typeof(DialogPropertyValueEditor))]
        public InArgument<string> CustomEditor { get; set; }

        /// <summary>
        ///     Enums will be displayed as DropdownBox in the options panel
        /// </summary>
        public ExamplePropertyOptions Options { get; set; }

        /// <summary>
        ///     Result of the asynchronously Processed File
        /// </summary>
        public OutArgument<string> Output { get; set; }

        /// <summary>
        ///     If your activity returns a value, derive from <see cref="AbstractCodeActivity{T}" />
        ///     and return the value from the Execute method.
        /// </summary>
        /// <param name="context"></param>
        protected override void ExecuteActivity(CodeActivityContext context)
        {
            // Obtain the runtime value of the CustomEditor input argument
            string customEditor = context.GetValue(CustomEditor);

            IExampleApplication exampleApplication = new ExampleApplication();
            exampleApplication.ExampleEditor = customEditor;

            context.SetValue(Output, "This text will be shown: " + customEditor);
        }
    }
}