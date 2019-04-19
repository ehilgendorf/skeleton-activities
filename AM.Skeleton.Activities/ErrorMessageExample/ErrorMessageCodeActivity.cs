using System.Activities;
using AM.Common.Activities.BaseActivities;

namespace AM.Skeleton.Activities
{
    public sealed class ErrorMessageCodeActivity : AbstractCodeActivity
    {
        public InArgument<string> Text { get; set; }

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

            // Checks if the Argument Text has been set if not we add a error message that will be displayed in the in the composer
            if (Text != null) metadata.AddValidationError("Argument Text has not been set.");
        }
    }
}