using System.Activities;
using AM.Common.Activities.BaseActivities;

namespace AM.Skeleton.Activities
{

    public sealed class ErrorMessageCodeActivity : AbstractCodeActivity
    {
        public InArgument<string> Text { get; set; }
        
        protected override void ExecuteActivity(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(Text);
            
        }


        /// <inheritdoc />
        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);
            
            // Checks if the Argument Text has been set if not we return an error
            if (Text != null)
            {
                metadata.AddValidationError("Argument Text has not been set.");
                
            }
            
        }
    }
}
