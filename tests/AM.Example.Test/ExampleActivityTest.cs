using System.Activities;
using System.Collections.Generic;
using AM.Example.Activities;
using NUnit.Framework;

namespace AM.Example.Test
{
    [TestFixture]
    public class ExampleActivityTest
    {
        [TestCase("hello world 1")]
        [TestCase("hello world 2")]
        public void ReturnTextTest(string text)
        {
            // Initialize the activity.
            ExampleCodeActivity exampleCodeActivity = new ExampleCodeActivity();

            // In this dictionary, all necessary input arguments are set.
            Dictionary<string, object> inputArguments = new Dictionary<string, object>
            {
                {"Text", text} // Key value pair with the name and the value for the input argument.
            };

            // Invoke the activity and return all out arguments.
            IDictionary<string, object> output = WorkflowInvoker.Invoke(exampleCodeActivity, inputArguments);

            // Get specific out argument, in this case; there is only one 'Output'.
            string outputValue = output["Output"].ToString();

            // Assert that the output is equal to the input after processing.
            Assert.AreEqual($"This text will be shown: {text}", outputValue);
        }
    }
}