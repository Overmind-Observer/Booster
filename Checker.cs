using System;
using System.Collections.Generic;
using System.Linq;

namespace Booster
{
    class Checker
    {

        static Checker() { }

        public static void Check(string iine) {

            ///Get text from stream
            ///
            string text = Reader.Get();

            ///Check the text
            ///
            Console.WriteLine("Stream: " + text);


        }

        public static void NumberOfChars(string  line)
        {
            ///Get text from stream
            ///
            string text = Reader.Get();

            ///Get number of total chars in the text with backspaces.
            ///
            Console.WriteLine("Number of charasaters = " + text.Length);

            ///Set exception for empty string or null
            ///
            if (text.Length == 0) throw new NullReferenceException("Something went wrong. Here is no charasters.");
        }

        public static void NumberOfWords(string line)
        {

            ///Get text from stream
            ///
            string text = Reader.Get();


            /// Set array of word splitters
            /// 
            char[] separators = " \r\n,.()[]{}\"'&^$!/\\".ToArray();

            /// Split the text with splitters
            /// 
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            ///Get number of all words
            ///
            Console.WriteLine("Number of words = " + words.Length);

            ///Set exception for empty string or null
            ///
            if (words.Length == 0) throw new NullReferenceException("Something went wrong. Here is no words.");
        }

        public static void FiveLongestWords(string line) {


            ///Get text from stream
            ///
            string text = Reader.Get();

                ///Set array of word splitters
                /// 
                char[] separators = " \r\n,.()[]{}\"'&^$!/\\".ToArray();

                /// Split the text with splitters
                /// 
                string[] LongWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            ///Get 5 longest words
            ///
           
                /// Initialise current max lenght
                /// 
                int max = -1; 

                ///Initialise the list of long words
                ///
                List<string> longWords = new List<string>();


                ///Start the algorithm of check the list and words' lenght
                ///
                foreach (string word in LongWords)
                {

                for (int t = 5; t > 0; t--)
                {
                    if (LongWords.Contains(word) == text.Contains(word))
                    {
                        max--;
                    }
                    /// lenght check and rewriting with a new long word
                    /// 
                    if (word.Length > max)
                    {
                        longWords.Clear();
                        max = word.Length;
                    }

                    /// Add all max lenght words in the list
                    /// 
                    if (word.Length == max)
                        longWords.Add(word);
                }
                }

            ///Output results
            ///
            Console.WriteLine(string.Join(", ", longWords));
            
        }
    }
}
