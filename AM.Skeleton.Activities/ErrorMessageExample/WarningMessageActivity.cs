﻿using System.Activities;
using System.Activities.Validation;
using AM.Common.Activities.BaseActivities;

namespace AM.Skeleton.Activities.ErrorMessageExample
{
    /// <summary>
    /// </summary>
    public sealed class WarningMessageActivity : AbstractCodeActivity
    {
        public InArgument<string> Text { get; set; }

        public OutArgument<string> Output { get; set; }

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