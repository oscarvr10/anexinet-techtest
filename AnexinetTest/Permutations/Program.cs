using System;

namespace Permutations
{
    /****
     * Write a function to print all permutations of a string. Max string length can be 50 characters.
    ****/
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter word to permutate: ");
            var word = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(word) || word.Length > 50)
            {
                Console.WriteLine("Enter a valid word with less than 50 caracters: ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\n\n***Permutate result: \n");
            PermuteString(word, 0, word.Length - 1);
        }


        /// <summary>
        /// Permutes a given word and print the result
        /// </summary>
        /// <param name="word">The word</param>
        /// <param name="startIndex">the start index</param>
        /// <param name="endIndex">The end index that represents the word length</param>
        static void PermuteString(string word, int startIndex, int endIndex)
        {
            if (startIndex != endIndex)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    word = SwapPositionCharsFromString(word, startIndex, i);
                    PermuteString(word, startIndex + 1, endIndex);
                    word = SwapPositionCharsFromString(word, startIndex, i);
                }
            }
            else
            {
                Console.WriteLine(word);
            }
        }


        /// <summary>
        /// Alows to swap position of characters from string
        /// </summary>
        /// <param name="str">The string to swap</param>
        /// <param name="startIndex">The start index</param>
        /// <param name="endIndex">The end index</param>
        /// <returns>A new swapped string</returns>
        static string SwapPositionCharsFromString(string str, int startIndex, int endIndex)
        {
            char tempChat;
            char[] charArr = str.ToCharArray();
            tempChat = charArr[startIndex];
            charArr[startIndex] = charArr[endIndex];
            charArr[endIndex] = tempChat;
            return new string(charArr);
        }
    }


}
