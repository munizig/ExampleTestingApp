using TestIntegration.App;
using NUnit.Framework;
using System;

namespace TestIntegration.Tests
{
    [TestFixture]
    public class CustomRecordTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ToCustomRecord_ShouldThrowExceptionWhenNameIsInvalid()
        {
            var ex = Assert.Throws<ArgumentException>(() => new CustomRecord(10, "   "));
            Assert.AreEqual("Name cannot be empty.", ex.Message);
        }
    }
}
