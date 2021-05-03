using System.Activities;
using System.Activities.Validation;
using AM.Activities.Common.BaseActivities;

namespace AM.Example.Activities.ErrorMessageExample
{
    /// <summary>
    ///     An example of how to create a custom warning message
    /// </summary>
    public sealed class WarningMessageActivity : AbstractCodeActivity
    {
        /// <summary>
        ///     Input argument that needs to be set to execute this activity
        /// </summary>
        public InArgument<string> Text { get; set; }

        /// <summary>
        ///     The output of this activity
        /// </summary>
        public OutArgument<string> Output { get; set; }

        /// <inheritdoc/>
        protected override void ExecuteActivity(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(Text);

            // Set the Output argument using the specified activity context.
            Output.Set(context, $"Input text is: {text}");
        }

        /// <inheritdoc />
        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            // If the Argument Text has not been set, show a warning message in the Composer
            if (Text == null)
            {
                ValidationError validationWarning = new ValidationError("Argument Text has not been set.", true);
                metadata.AddValidationError(validationWarning);
            }
        }
    }
}