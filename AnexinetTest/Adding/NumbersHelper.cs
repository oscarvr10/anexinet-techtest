namespace Adding
{
    internal class NumbersHelper
    {
        /// <summary>
        /// Adds two given numbers and returns the result
        /// </summary>
        /// <param name="num1">The first number represented as string</param>
        /// <param name="num2">The second number represented as string</param>
        /// <returns>Result from adding two numbers</returns>
        internal int AddNumbers(string num1, string num2)
        {
            int.TryParse(num1, out int number1);
            int.TryParse(num2, out int number2);
            if(number1 != 0 && number2 != 0)
            {
                while (number2 > 0)
                {
                    number1++;
                    number2--;
                }
                return number1;
            }

            return 0;
        }

        /// <summary>
        /// Checks if the given number is positive
        /// </summary>
        /// <param name="number">The number represented as string</param>
        /// <returns>Returns <c>true</c> if that is positive number, otherwise returns <c>false</c></returns>
        internal bool CheckIsPositiveNumber(string number)
        {
            int.TryParse(number, out int result);
            return result > 0;
        }
    }
}
