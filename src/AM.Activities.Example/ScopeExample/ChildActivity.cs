using System.Activities;
using AM.Activities.Common;
using AM.Activities.Common.BaseActivities;
using AM.Activities.Example.Application;

namespace AM.Activities.Example.ScopeExample
{
    /// <summary>
    ///     Child Activity that gets the ExampleApplication object from the parent
    /// </summary>
    public class ChildActivity : AbstractCodeActivity
    {
        public ChildActivity()
        {
            // Indicates that this activity should reside inside a specific scope activity in this case ScopeActivity
            Constraints.Add(
                ActivityConstraints.CreateAncestorConstraint<ChildActivity>(typeof(ScopeActivity),
                    isWarning: true));
        }

        /// <summary>
        ///     Output argument that shows the option that has been set in the scope activity.
        /// </summary>
        public OutArgument<string> Option { get; set; }

        /// <summary>
        ///     Executes the Activity, gets the context object from the scope and sets the value into Option argument.
        /// </summary>
        /// <param name="context">The execution context of the activity.</param>
        protected override void ExecuteActivity(CodeActivityContext context)
        {
            // Get the ExampleApplication that has been set in the scope activity from the current context.
            IExampleApplication exampleApplication =
                context.DataContext.GetProperties()[ScopeActivity.ScopeContextItemName].GetValue(context.DataContext) as
                    IExampleApplication;

            if (exampleApplication != null)
            {
                ExamplePropertyOptions option = exampleApplication.GetOption();
                Option.Set(context, option.ToString());
            }
        }
    }
}