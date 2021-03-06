﻿using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        private const int MaxPrime = 97;

        public string GetResult(int input)
        {
            if (InputIsDivisibleByThree(input) && InputIsDivisibleByFive(input))
            {
                return "FizzBuzz";
            }

            if (InputIsDivisibleByFive(input))
            {
                return "Buzz" + WhizSuffix(input);
            }

            if (InputIsDivisibleByThree(input))
            {
                return "Fizz" + WhizSuffix(input);
            }

            return IsPrimeNumber(input) ?  WhizSuffix(input) : InputAsString(input);
        }

        private static string InputAsString(int input)
        {
            return input.ToString();
        }

        private string WhizSuffix(int input)
        {
            if (IsPrimeNumber(input))
            {
                return "Whiz";
            }

            return string.Empty;
        }

        private static bool IsPrimeNumber(int input)
        {
            if (input > MaxPrime)
            {
                return false;
            }

            return Enumerable.Range(1, input)
                .Where(x => input % x == 0)
                .SequenceEqual(new[] {1, input});
        }

        private static bool InputIsDivisibleByFive(int input)
        {
            return input % 5 == 0;
        }

        private static bool InputIsDivisibleByThree(int input)
        {
            return input % 3 == 0;
        }
    }
}
