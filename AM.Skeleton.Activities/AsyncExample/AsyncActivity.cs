using System.Activities;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AM.Common.Activities.BaseActivities;

namespace AM.Skeleton.Activities.AsyncExample
{
    /// <summary>
    /// Basic example of a long running Task 
    /// </summary>
    public class AsyncActivity : AbstractTaskAsyncCodeActivity
    {
        public InArgument<string> FilePath { get; set; }
        
        static async void HandleFileAsync(string file)
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
                    if (x == 0)
                    {
                        count--;
                    } 
                }
            }
        }

        protected override Task ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            string file = FilePath.Get(context);
            
            return Task.Factory.StartNew(()=> HandleFileAsync(file),cancellationToken);
        }
    }
}