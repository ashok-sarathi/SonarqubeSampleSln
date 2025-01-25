using SonarqubeSample;

namespace SonarqubeTestSample
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        public void CheckAddition(int input1, int input2, int result)
        {
            Assert.Equal(Calculator.Addition(input1, input2), result);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(2, 2, 0)]
        public void CheckSubtraction(int input1, int input2, int result)
        {
            Assert.Equal(Calculator.Subtraction(input1, input2), result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 2, 6)]
        public void CheckMultiplication(int input1, int input2, int result)
        {
            Assert.Equal(Calculator.Multiplication(input1, input2), result);
        }

        [Theory]
        [InlineData(12, 6, 2)]
        [InlineData(24, 2, 12)]
        public void CheckDivision(int input1, int input2, int result)
        {
            Assert.Equal(Calculator.Division(input1, input2), result);
        }
    }
}