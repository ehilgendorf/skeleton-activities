using System.Collections.Generic;
using System.Activities;
using System.Activities.Presentation.PropertyEditing;
using System.ComponentModel;
using AM.Common.Activities.BaseActivities;
using AM.Common.Activities.Design.Editors;
using AM.Core.ActivityDesignBase.Attributes;
using AM.Skeleton.Application;

namespace AM.Skeleton.Activities
{

    public sealed class ExampleCodeActivity : AbstractCodeActivity
    {
        // Attributes can be set either directly above the properties as shown here, or loaded though xml files.
        [Category("Input")]
        [DisplayName("Input Text*")]
        [RequiredArgument]
        [VariableSelectionInputTextPopup]
        [Description("This text will be shown in the output")]
        public InArgument<string> Text { get; set; }
        
        // InArgument's can be extended with a custom editor to add more functionality. In this case it will show a FileDialog
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

        // If your activity returns a value, derive from AbstractCodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void ExecuteActivity(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(Text);
            
            // Obtain the runtime value of the CustomEditor input argument
            string customEditor = context.GetValue(CustomEditor);
            
            IExampleApplication test = new ExampleApplication();
            string result = test.ReturnText(text);
            
            test.SetOption(Options);
            
            context.SetValue(Output,"This text will be shown: " + result);
        }
    }
}
