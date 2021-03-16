using ChampionX.App;
using NUnit.Framework;
using System;

namespace ChampionX.Tests
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
            CustomRecord record = _customService.GetRecord(1);
            Assert.NotNull(record);
            Assert.AreEqual(1, record.Id);
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