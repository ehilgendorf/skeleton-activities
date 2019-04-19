using System.Activities;
using System.Activities.Presentation.PropertyEditing;
using System.ComponentModel;
using AM.Common.Activities.BaseActivities;
using AM.Common.Activities.Design.Editors;
using AM.Core.ActivityDesignBase.Attributes;
using AM.Skeleton.Application;

namespace AM.Skeleton.Activities.CustomEditor
{
    public sealed class CustomEditorCodeActivity : AbstractCodeActivity
    {
        // InArgument's can be displayed with a custom editor to add more functionality. In this case it will show a FileDialog
        [Editor(typeof(FileBrowserDialogEditor), typeof(DialogPropertyValueEditor))]
        public InArgument<string> CustomEditor { get; set; }

        // Enums will be displayed as DropdownBox in the options panel    
        public ExamplePropertyOptions Options { get; set; }

        [Category("Output")]
        [DisplayName("Output*")]
        [RequiredArgument]
        [VariableSelectionOutputPopup]
        [Description("The result of your activity will be shown in this activity")]
        public OutArgument<string> Output { get; set; }

        
        /// <summary>
        /// If your activity returns a value, derive from <see cref="AbstractCodeActivity{T}"/>
        /// and return the value from the Execute method.</summary>
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