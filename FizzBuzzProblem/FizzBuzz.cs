namespace FizzBuzzProblem
{
    public class FizzBuzz
    {
        public static List<string> GetFizzBuzz(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Input must be greater than 0");
            }
            
            List<string> numbers = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    numbers.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    numbers.Add("Fizz");
                }

                else if (i % 5 == 0)
                {
                    numbers.Add("Buzz");
                }
                else
                {
                    numbers.Add(i.ToString());
                }
            }
            return numbers; 
        }
    }
}