using System.Activities;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AM.Common.Activities.BaseActivities;

namespace AM.Skeleton.Activities.AsyncExample
{
    public class AsyncWithResultActivity : AbstractTaskAsyncCodeActivity<int>
    {
        public InArgument<string> FilePath { get; set; }

        public OutArgument<int> Result { get; set; }

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