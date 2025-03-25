using Xunit;
using Program;

namespace Program
{
    public class TestClass
    {
        [Fact]
        public void TestMethodAdd()
        {
            //arrange

            //act
            int result = Program.Add(2, 2);
            //assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void TestMethodSubtract()
        {
            //arrange

            //act
            int result = Program.Subtract(2, 2);
            //assert
            Assert.Equal(0, result);
        }
    }

}