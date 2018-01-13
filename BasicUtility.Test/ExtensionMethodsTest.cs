using Xunit;

namespace BasicUtility.Test
{
    public class ExtensionMethodsTest
    {
        [Fact]
        public void IntToBinaryString()
        {
            var str = 1024.ToBinaryString();
            Assert.Equal(expected: "10000000000", actual: str);
        }
    }
}
