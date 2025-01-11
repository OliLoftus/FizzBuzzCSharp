namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void TestFizzBuzz()
        {
            // Arrange
            int input = 5;

            // Act
            var result = FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input); // Fully qualify the reference

            // Assert
            Assert.NotNull(result);
        }
    }
}