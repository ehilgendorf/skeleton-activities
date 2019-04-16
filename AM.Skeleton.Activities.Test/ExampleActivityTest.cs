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
        public void ReturnTextTest(string teststring)
        {
            IExampleApplication test = new ExampleApplication();
            string testresult =  test.ReturnText(teststring);
            Assert.That(testresult,Is.EqualTo("This text will be shown: " +teststring));

        }
    }
}
 