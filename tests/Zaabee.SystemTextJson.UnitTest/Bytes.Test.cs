using System;
using TestModels;
using Xunit;

namespace Zaabee.SystemTextJson.UnitTest
{
    public partial class SystemTextJsonUnitTest
    {
        [Fact]
        public void BytesTest()
        {
            var testModel = TestModelFactory.Create();
            var bytes = testModel.ToBytes();
            var result = bytes.FromBytes<TestModel>();
            Assert.Equal(
                Tuple.Create(testModel.Id, testModel.Age, testModel.CreateTime, testModel.Name, testModel.Gender),
                Tuple.Create(result.Id, result.Age, result.CreateTime, result.Name, result.Gender));
        }
    }
}