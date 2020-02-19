using System;

namespace Circles
{
    /****
     * Write a function that can accept any number and return the number of circles inside the number, e.g.
       24690 as 3 circles, one for 6, another for 9 and another for 0, 7431 doesn't have any circles inside.
    ****/
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number = Console.ReadLine();
            int.TryParse(number, out int num);
            if(num == 0)
            {
                Console.WriteLine("Enter a valid number: ");
                Console.ReadKey();
                return;
            }

            var result = GetTotalCircles(num);
            Console.WriteLine($"the number of circles inside the '{num}' is: {result}");
        }


        /// <summary>
        /// Returns the number of circles inside the specific number
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>The number of circles</returns>
        static int GetTotalCircles(int number)
        {
            var circleDigitsArr = new int[] { 0, 6, 8, 9 };
            int counter = 0;
            var numberArr = number.ToString().ToCharArray();
            foreach (var item in numberArr)
            {
                int.TryParse(item.ToString(), out int num);
                foreach (var circleNum in circleDigitsArr)
                {
                    if (num == circleNum)
                    {
                        if (num == 8)
                            counter += 2;
                        else
                            counter++;
                    }
                }
            }

            return counter;
        }
    }
}
