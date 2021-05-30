using NLipsum.Core;
using Booster.CodingTest.Library;

namespace Booster
{
    class WordStream 
    {
        public static string Get()
        {          
            ///Reading stream and transfer it to the string
            ///
            var stream = new CodingTest.Library.WordStream();
            stream.ReadByte();
        }
    }
}
