namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void FizzBuzz_Not_Null()
        {
            // Arrange
            int input = 5;

            // Act
            List<string> result = FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input); 

            // Assert
            Assert.NotNull(result);
        }
        
        [Fact]
        public void Zero_Input_Throws_Exception()
        {
            // Arrange
            int input = -1;
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void Returns_List_Of_Numbers()
        {
            // Arrange
            int input = 2;
            
            // Act
            List<string> result = FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input);
            
            // Assert
            Assert.Equal(new List<string> { "1", "2" }, result);
        }
        
        [Fact]
        public void Fizz_With_Three()
        {
            // Arrange
            int input = 3;
            
            // Act
            List<string> result = FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input);
            
            // Assert
            Assert.Equal(new List<string> { "1", "2", "Fizz" }, result);
        }
        
        [Fact]
        public void Buzz_With_Five()
        {
            // Arrange
            int input = 5;
            
            // Act
            List<string> result = FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input);
            
            // Assert
            Assert.Equal(new List<string> { "1", "2", "Fizz", "4", "Buzz" }, result);
        }
        
        [Fact]
        public void Negative_Input_Throws_Exception()
        {
            // Arrange
            int input = -1;
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input));
        }
        
        [Fact]
        public void FizzBuzz_With_Fifteen()
        {
            // Arrange
            int input = 15;
            
            // Act
            List<string> result = FizzBuzzProblem.FizzBuzz.GetFizzBuzz(input);
            
            // Assert
            Assert.Equal(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, result);
        }
    }
}