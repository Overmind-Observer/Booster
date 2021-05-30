using System;
using System.Collections.Generic;
using System.Linq;

namespace Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Get results from the text's check
            ///
            Checker.Check(WordStream.Get());
            Checker.NumberOfChars(WordStream.Get());
            Checker.NumberOfWords(WordStream.Get());
            Checker.FiveLongestWords(WordStream.Get());

        }
    }
}
