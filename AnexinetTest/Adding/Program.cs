using System;

namespace Adding
{
    /****
     * Write a function that receives two numeric parameters (positive integers), adds them and prints the result
        in the console. You should not use + or any arithmetic operators
    ****/

    class MainClass
    {
        public static void Main(string[] args)
        {
            var helper = new NumbersHelper();

            Console.WriteLine("Enter first number: ");
            var num1 = Console.ReadLine();

            if (!helper.CheckIsPositiveNumber(num1))
            {
                Console.WriteLine("Enter a positive number: ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Enter second number: ");
            var num2 = Console.ReadLine();

            if (!helper.CheckIsPositiveNumber(num2))
            {
                Console.WriteLine("Enter a positive number: ");
                Console.ReadKey(false);
                return;
            }

            var result = helper.AddNumbers(num1, num2);
            Console.WriteLine("The result is: " + result.ToString());
        }
    }
}
