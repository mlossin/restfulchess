using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Implementations.Extensions
{
    /// <summary>
    /// Useful integer extensions
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Do an action the amount of times represented by that integer
        /// </summary>
        public static void Times(this int number, Action action)
        {
            for (int i = 0; i < number; i++)
            {
                action();
            }
        }

        /// <summary>
        /// Convert to a binary string
        /// </summary>
        public static string ToBinary(this int number)
        {
            return Convert.ToString(number, 2);
        }

        /// <summary>
        /// Convert to a hex string
        /// </summary>
        public static string ToHexadecimal(this int number)
        {
            return Convert.ToString(number, 16);
        }

        /// <summary>
        /// check if that number is a prime (slow)
        /// </summary>
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// check if the number is even
        /// </summary>
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// check if the number is odd
        /// </summary>
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

    }
}
