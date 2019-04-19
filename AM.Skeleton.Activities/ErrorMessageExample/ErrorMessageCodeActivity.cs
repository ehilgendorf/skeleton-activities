using System.Activities;
using AM.Common.Activities.BaseActivities;

namespace AM.Skeleton.Activities.ErrorMessageExample
{
    /// <summary>
    ///     An example of how to create a custom error message
    /// </summary>
    public sealed class ErrorMessageActivity : AbstractCodeActivity
    {
        /// <summary>
        ///     Input argument that needs to be set to execute this activity
        /// </summary>
        public InArgument<string> Text { get; set; }

        /// <summary>
        ///     The output of this activity
        /// </summary>
        public OutArgument<string> Output { get; set; }

        protected override void ExecuteActivity(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(Text);

            Output.Set(context, $"Input text is: {text}");
        }

        /// <inheritdoc />
        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            // If the Argument Text has not been set, show a error message in the Composer
            if (Text == null) metadata.AddValidationError("Argument Text has not been set.");
        }
    }
}