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
            Checker.Check(Reader.Get());
            Checker.NumberOfChars(Reader.Get());
            Checker.NumberOfWords(Reader.Get());
            Checker.FiveLongestWords(Reader.Get());

        }
    }
}
