using System;
using System.Collections.Generic;

namespace Anagrams
{
    /****
     * Write a method to sort an array of strings so that all the anagrams are next to each other.
    ****/
    class MainClass
    {
        public static void Main(string[] args)
        {
            var wordsArr = new[] { "arm", "tar", "bare", "rat", "tea", "eat", "bear", "ram" };
           
            Console.WriteLine("***Words array*** \n");
            foreach (var word in wordsArr)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine("\n\n***Anagram Words Result**** \n");

            Anagram.PrintAnagramWords(wordsArr);
            Console.ReadKey();
        }
    }

    public static class Anagram
    {
        /// <summary>
        /// Given words array, orders and prints all anagrams together
        /// </summary>
        /// <param name="wordsArray">The string array</param>
        public static void PrintAnagramWords(string[] wordsArray)
        {
            var map = new Dictionary<string, List<string>>();

            // loop over words array
            for (int i = 0; i < wordsArray.Length; i++)
            {
                // convert word to char array, sort and then create new string based on sorted string
                var word = wordsArray[i];
                char[] letters = word.ToCharArray();
                Array.Sort(letters);
                var newWord = new string(letters);

                // Check if hashcode of sorted string exists in map, if so put original string into it
                // otherwise create new hashcode with sorted word as key and empty list as value 
                if (map.ContainsKey(newWord))
                {
                    map[newWord].Add(word);
                }
                else
                {
                    List<String> words = new List<String>();
                    words.Add(word);
                    map.Add(newWord, words);
                }
            }

            // Create and fill new string list with keys from map
            var value = new List<string>();
            foreach (var entry in map)
            {
                value.Add(entry.Key);
            }
            int j = 0;

            foreach (var entry in map)
            {
                List<String> values = map[value[j++]];
                if (values.Count > 1)
                {
                    Console.Write("|");
                    int len = 1;
                    foreach (var str in values)
                    {
                        //Print anagrams
                        Console.Write(str);
                        if (len++ < values.Count)
                            Console.Write(", ");
                    }
                    Console.Write("| ");
                }
            }
        }
    }

}
