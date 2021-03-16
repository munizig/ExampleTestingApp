using TestIntegration.App;
using NUnit.Framework;
using System;

namespace TestIntegration.Tests
{
    [TestFixture]
    public class CustomServiceTest
    {
        private CustomService _customService;

        [SetUp]
        public void SetUp()
        {
            _customService = new CustomService();
        }

        [Test]
        public void FromCustomService_ShouldRetrieveValidRecordById()
        {
            int newRecordId = 3;
            //RecordId must be higher than 2
            CustomRecord record = _customService.GetRecord(newRecordId);
            Assert.NotNull(record);
            Assert.AreEqual(newRecordId, record.Id);
            Assert.NotNull(record.Name);
        }

        [TestCase(7)]
        [TestCase(10)]
        public void FromCustomService_ShouldThrowExceptionForOutOfRangeId(int value)
        {
            var ex = Assert.Throws<ArgumentException>(() => _customService.GetRecord(value));
            Assert.AreEqual("Id not found.", ex.Message);
        }
        
    }
}