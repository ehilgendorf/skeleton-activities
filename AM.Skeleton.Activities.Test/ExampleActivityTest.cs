using System;
using NUnit.Framework;
using AM.Skeleton.Application;
namespace AM.Skeleton.Activities.Test
{
    [TestFixture]
    public class ExampleActivityTest
    {
        [Test]
        [TestCase("hello world")]
        [TestCase("hello world 2")]
        public void ReturnTextTest(string value)
        {
            IExampleApplication test = new ExampleApplication();
            string testresult =  test.ReturnText(value);
            Assert.That(testresult,Is.EqualTo("This text will be shown: " + value));

        }
    }
}
 