using Xunit;

namespace Lesson001_XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange: variables and inputs
            MyMath mm = new MyMath();
            int input1 = 10, input2 = 5;
            int expected = 15;

            //Act: calling methods
            int actual = mm.Add(input1, input2);

            //Assert: comparing expected value and real value
            Assert.Equal(expected, actual);
        }
    }
}