using System;
using AM.Skeleton.Helper;
using NUnit.Framework;

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
            IExampleHelper test = new ExampleHelper();
            string testresult =  test.ReturnText(teststring);
            Assert.That(testresult,Is.EqualTo("This text will be shown: " +teststring));

        }
    }
}
 