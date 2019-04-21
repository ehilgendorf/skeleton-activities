using System.Activities;
using System.Collections.Generic;
using NUnit.Framework;

namespace AM.Skeleton.Activities.Test
{
    [TestFixture]
    public class ExampleActivityTest
    {
        [TestCase("hello world")]
        [TestCase("hello world 2")]
        public void ReturnTextTest(string value)
        {
            Dictionary<string, object> input = new Dictionary<string, object>
            {
                {"Text", value}
            };

            ExampleCodeActivity exampleCodeActivity = new ExampleCodeActivity();

            IDictionary<string, object> output = WorkflowInvoker.Invoke(exampleCodeActivity, input);

            string outputValue = output["Output"].ToString();

            Assert.AreEqual($"This text will be shown: {value} ", outputValue);
        }
    }
}