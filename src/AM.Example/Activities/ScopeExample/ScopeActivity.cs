using System.Activities;
using System.Activities.Statements;
using System.Threading;
using System.Threading.Tasks;
using AM.Activities.Common.BaseActivities;
using AM.Example.Application;

namespace AM.Example.Activities.ScopeExample
{
    /// <summary>
    ///     Example of how to create a Scope activity that passes an object down to its children
    /// </summary>
    public class ScopeActivity : AbstractScopeActivity
    {
        public ScopeActivity()
        {
            // An ActivityAction is defined as body of the scope. This allows the ScopeActivity to propagate a context object to child activities.
            ContainerBody = new ActivityAction<object>
            {
                Argument = new DelegateInArgument<object>(ScopeContextItemName),
                Handler = new Flowchart()
                {
                    DisplayName = "Do"
                }
            };
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