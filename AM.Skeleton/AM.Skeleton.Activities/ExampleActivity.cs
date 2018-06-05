using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;
using AM.Core.ActivityDesignBase.Attributes;
using AM.Skeleton.Helper;

namespace AM.Skeleton.Activities
{

    public sealed class ExampleActivity : CodeActivity
    {
        // Define an activity input argument of type string
        [Category("Input")]
        [DisplayName("Input Text*")]
        [RequiredArgument]
        [VariableSelectionInputTextPopup]
        [Description("This text will be shown in the output")]
        public InArgument<string> Text { get; set; }
        [Category("Output")]
        [DisplayName("Output*")]
        [RequiredArgument]
        [VariableSelectionOutputPopup]
        [Description("The result of your activity will be shown in this activity")]
        public OutArgument<string> Output { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);

            context.SetValue(Output,"This text will be shown: " + text);
        }
    }
}
