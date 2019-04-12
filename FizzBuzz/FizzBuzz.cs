namespace FizzBuzz
{
    public class FizzBuzz

    {
        private const string Fizz = "FIZZ";
        private const int FizzFactor = 3;
        private const string Buzz = "BUZZ";
        readonly int _number;
        private const int BuzzFactor = 5;
        private const string Fizzbuzz = "FIZZBUZZ";

        public FizzBuzz(int number)
        {
            _number = number;
        }


        public string Execute()
        {
            if (NumberIsBuzzy() && NumberIsFizzy()) return Fizzbuzz;
            if (NumberIsBuzzy()) return Buzz;
            if (NumberIsFizzy()) return Fizz; 
            return _number.ToString();
        }

        private bool NumberIsFizzy()
        {
            return _number % FizzFactor == 0;
        }

        private bool NumberIsBuzzy()
        {
            return _number % BuzzFactor == 0;
        }
    }
}