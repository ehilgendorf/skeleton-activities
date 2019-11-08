using System.Activities;
using System.Activities.Presentation.PropertyEditing;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AM.Common.Activities.BaseActivities;
using AM.Common.Activities.Design.Editors;

namespace AM.Skeleton.Activities.AsyncExample
{
    /// <summary>
    ///     Activity that runs a Task asynchronously and returns a value on completion,
    ///     <see cref="AbstractTaskAsyncCodeActivity" /> handles delays, cancellation and error handling.
    ///     To simple run a Task see <see cref="AsyncActivity" /> for a example
    /// </summary>
    public class AsyncWithResultActivity : AbstractTaskAsyncCodeActivity<int>
    {
        /// <summary>
        ///     Path to a file that will be processed asynchronously
        /// </summary>
        [Editor(typeof(FileBrowserDialogEditor),
            typeof(DialogPropertyValueEditor))] // InArguments can be displayed with a custom editor to add more functionality. In this case it will show a FileDialog
        public InArgument<string> FilePath { get; set; }

        /// <summary>
        ///     Result of the asynchronously Processed File
        /// </summary>
        public OutArgument<int> Result { get; set; }

        /// <summary>
        ///     Asynchronous function that will process a file and returns a <see cref="Task{TResult}" />
        /// </summary>
        /// <param name="file">Path to the file that will be processed</param>
        private static async Task<int> HandleFileAsync(string file)
        {
            int count = 0;

            // Read the specified file asynchronously.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                //Process the file data somehow.
                count += v.Length;

                // A slow-running computation.
                // Dummy code.
                for (int i = 0; i < 10000; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0) count--;
                }
            }

            return count;
        }

        /// <summary>
        ///     Execute a long running Task
        /// </summary>
        protected override Task<int> ExecuteAsyncWithResult(AsyncCodeActivityContext context,
            CancellationToken cancellationToken)
        {
            string file = FilePath.Get(context);

            return Task.Factory.StartNew(() => HandleFileAsync(file), cancellationToken).Result;
        }

        /// <summary>
        ///     On Task completion the result will be set
        /// </summary>
        protected override void OutputResult(AsyncCodeActivityContext context, int result)
        {
            Result.Set(context, result);
        }
    }
}