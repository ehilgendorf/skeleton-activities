using System.Activities;
using System.Activities.Statements;
using System.Threading;
using System.Threading.Tasks;
using AM.Common.Activities.BaseActivities;
using AM.Skeleton.Application;

namespace AM.Skeleton.Activities.ScopeExample
{
    /// <summary>
    ///     Example of how to create a Scope activity that passes an object down to its children
    /// </summary>
    public class ScopeActivity : AbstractScopeActivity
    {
        public ScopeActivity()
        {
            // Declares a ActivityAction with the name from ScopeContextItemName, this allows child activities to get te context object from this activity.
            ActivityAction<object> action = new ActivityAction<object>
            {
                Argument = new DelegateInArgument<object>(ScopeContextItemName)
            };

            // Creates a new Flowchart with the name Do.
            Flowchart flowchart = new Flowchart
            {
                DisplayName = "Do"
            };

            // Adds the Flowchart to the action. 
            action.Handler = flowchart;

            // As container we use the Action with the Flowchart. This allows children to get access to the OutArgument of this activity
            ContainerBody = action;
        }

        /// <summary>
        ///     Name that will be used to get the Context object by.
        /// </summary>
        public static string ScopeContextItemName => "ScopeActivityContextObject";

        /// <summary>
        ///     ExampleApplication object that will be made available for the child activities
        /// </summary>
        public OutArgument<IExampleApplication> ScopeExampleApplication { get; set; }

        protected override Task<object> ExecuteContainerActivity(NativeActivityContext context, CancellationToken token)
        {     
            // If ScopeExampleApplication is set use the provided value else create an ExampleApplication object.
            IExampleApplication application = ScopeExampleApplication.Get(context) ?? new ExampleApplication();

            return Task.Factory.StartNew(() =>
            {
                application.SetOption(ExamplePropertyOptions.Option1);

                return (object)application;
            }, token);
        }

        protected override void SetResult(NativeActivityContext context, object result)
        {
            ScopeExampleApplication.Set(context, result);
        }
    }
}