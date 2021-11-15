using Xunit;
using Tynamix;

namespace ABCTests
{
    public class DataProcessorServiceTests
    {
        [Fact]
        public void Test1()
        {
            string name = new Tynamix.ObjectFiller.RealNames().GetValue();
            Assert.True(true);
        }
    }
}