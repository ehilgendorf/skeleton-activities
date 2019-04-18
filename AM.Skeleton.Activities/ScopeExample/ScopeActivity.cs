using System.Activities;
using System.Activities.Statements;
using System.Threading;
using System.Threading.Tasks;
using AM.Common.Activities.BaseActivities;
using AM.Skeleton.Application;

namespace AM.Skeleton.Activities.ScopeExample
{
    public class ScopeActivity : AbstractScopeActivity
    {
        public OutArgument<string> TextToPassToChildren { get; set; }

        public static string ScopeContextItemName => "ScopeActivityContextObject";

        public ScopeActivity()
        {
            var action = new ActivityAction<object>
            {
                Argument = new DelegateInArgument<object>(ScopeContextItemName)
            };

            var flowchart = new Flowchart();
            const string str = "Do";
            flowchart.DisplayName = str;
            action.Handler = flowchart;
            ContainerBody = action;
        }

        protected override Task<object> ExecuteContainerActivity(NativeActivityContext context, CancellationToken token)
        {
            return Task.Factory.StartNew(() =>
            {
                ExampleApplication app = new ExampleApplication();
                
                // If TextToPassToChildren is set use the provided value else get text from ExampleApplication
                string value = TextToPassToChildren.Get(context) ?? app.ReturnText("Text to pass to children");
                
                return (object) value;
            }, token);
        }

        protected override void SetResult(NativeActivityContext context, object result)
        {
            TextToPassToChildren.Set(context, result);
        }
    }
}