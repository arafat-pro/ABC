using Xunit;
using Tynamix;
using Moq;
using ABC.Brokers;
using System.Collections.Generic;
using Tynamix.ObjectFiller;
using System.Linq;
using ABC.Services;
using FluentAssertions;

namespace ABCTests
{
    public class DataProcessorServiceTests
    {
        [Fact]
        public void ShouldCallStorageBroker()
        {
            //given
            var storageBrokerMock = new Mock<IStorageBroker>();
            var returnedDataFiller = new Filler<string>();
            List<string> returnedData = returnedDataFiller.Create(10).ToList();
            
            List<string> expectedResult = 
                returnedData.Select(item => item.ToUpper())
                .ToList();

            storageBrokerMock.Setup(Broker => Broker.GetAllData()).Returns(returnedData);

            //when
            var dataProcessorService = new DataProcessorService(storageBrokerMock.Object);
            List<string> actualResult = dataProcessorService.ProcessData();

            //then

            storageBrokerMock.Verify(broker => 
                broker.GetAllData(),
                    Times.Once(),
                    "Storage Broker Should be Called at least once for Data Processing!");

            actualResult.Should().BeEquivalentTo(expectedResult, because:"Returned List should be both uppercase!");

            //==
            //string name = new Tynamix.ObjectFiller.RealNames().GetValue();
            //Assert.True(true);
        }
    }
}